import base64
from io import BytesIO
from jinja2 import Environment, FileSystemLoader
import matplotlib.pyplot as plt
import pandas as pd
import os

def create_evm_report(metrics, df, report_date, output_path='evm_report.html'):
    #create charts
    charts = generate_evm_charts(metrics, df, report_date)

    #prepare data for template
    report_data = {
        'project_name': 'Project Dashboard',
        'report_date': report_date.strftime('%Y-%m-%d'),
        'metrics': metrics,
        'charts': charts,
        'tasks_count': len(df),
        'completed_tasks': len(df[df['completion_pct'] == 100]),
        'total_budget': metrics['BAC'],
        'performance_status': get_performance_status(metrics)  # ДОБАВЛЕНО
    }
    #render html
    base_dir = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
    templates_dir = os.path.join(base_dir, 'templates')

    env = Environment(loader=FileSystemLoader(templates_dir))
    template = env.get_template('report.html')
    html_output = template.render(**report_data)

    #save file
    with open(output_path, 'w', encoding='utf-8') as f:
        f.write(html_output)
    return output_path

def generate_evm_charts(metrics, df, report_date):
    charts = {}

    # 1. PV/EV/AC graphs - УМЕНЬШЕН РАЗМЕР
    fig, (ax1, ax2) = plt.subplots(1, 2, figsize=(10, 4))  # было (12, 5)

    # main metrics
    ax1.bar(['PV', 'EV', 'AC'], [metrics['PV'], metrics['EV'], metrics['AC']],
            color=['blue', 'green', 'red'], alpha=0.7)
    ax1.set_title('PV vs EV vs AC')
    ax1.set_ylabel('Cost ($)')
    ax1.grid(True, alpha=0.3)

    # productivity indexes
    ax2.bar(['CPI', 'SPI'], [metrics['CPI'], metrics['SPI']],
            color=['orange', 'purple'], alpha=0.7)
    ax2.axhline(y=1, color='red', linestyle='--', label='Целевое значение (1.0)')
    ax2.set_title('CPI и SPI')
    ax2.set_ylabel('Значение')
    ax2.legend()
    ax2.grid(True, alpha=0.3)

    plt.tight_layout()
    charts['metrics_chart'] = plot_to_base64(fig)
    plt.close()

    # 2. task completion graph - ИСПРАВЛЕН РАЗМЕР И ПОДПИСИ
    fig, ax = plt.subplots(figsize=(8, 6))  # было (10, 10) - слишком большой
    
    # Сортируем и ограничиваем количество задач для отображения
    df_sorted = df.sort_values('completion_pct', ascending=False)
    
    # Если задач слишком много, показываем только топ-15
    if len(df_sorted) > 15:
        df_display = df_sorted.head(15)
        ax.set_title(f'Статус выполнения задач (топ-15 из {len(df)})')
    else:
        df_display = df_sorted
        ax.set_title('Статус выполнения задач')
    
    bars = ax.barh(df_display['task_id'].astype(str), df_display['completion_pct'],
                   color=['green' if x == 100 else 'orange' for x in df_display['completion_pct']])
    ax.set_xlabel('Процент выполнения (%)')
    ax.grid(True, alpha=0.3)

    # УМЕНЬШЕН РАЗМЕР ШРИФТА И ДОБАВЛЕНА ПРОВЕРКА ГРАНИЦ
    for bar in bars:
        width = bar.get_width()
        # Проверяем, чтобы текст не вылезал за границы
        x_pos = width + 0.5  # уменьшил отступ
        max_width = ax.get_xlim()[1]  # максимальная ширина графика
        
        # Если текст вылезает, помещаем его внутри столбца
        if x_pos > max_width * 0.95:
            x_pos = width - 2  # помещаем внутрь столбца
            color = 'white'    # белый текст для контраста
        else:
            color = 'black'    # черный текст по умолчанию
            
        ax.text(x_pos, bar.get_y() + bar.get_height()/2, f"{width:.0f}%",
                ha='left', va='center', fontsize=8, color=color)  # уменьшил шрифт
    
    # Устанавливаем границы графика с запасом
    ax.set_xlim(0, max(df_display['completion_pct']) * 1.15)  # +15% запаса
    
    plt.tight_layout()
    charts['tasks_chart'] = plot_to_base64(fig)
    plt.close()

    return charts

def plot_to_base64(fig):
    buffer = BytesIO()
    fig.savefig(buffer, format='png', dpi=100, bbox_inches='tight')
    buffer.seek(0)
    return base64.b64encode(buffer.read()).decode()

def get_performance_status(metrics):
    status = []

    if metrics['CPI'] < 1:
        status.append('❌ **Перерасход бюджета** (CPI < 1)')
    else: 
        status.append('✅ **Бюджет в норме**')
    
    if metrics['SPI'] < 1:
        status.append('❌ **Отставание от графика** (SPI < 1)')
    else:
        status.append('✅ **График выполняется**')

    if metrics['VAC'] < 0:
        status.append(f"⚠️ **Прогнозируемый перерасход:** ${abs(metrics['VAC']):,.2f}")
    else:
        status.append(f"✅ **Прогнозируемая экономия:** ${metrics['VAC']:,.2f}")

    return status