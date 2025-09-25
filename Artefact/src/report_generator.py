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
        'total_budget': metrics['BAC']
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

    # 1. PV/EV/AC graphs
    fig, (ax1, ax2) = plt.subplots(1, 2, figsize=(12, 5))

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

    # 2. task completion graph
    fig, ax = plt.subplots(figsize=(10, 6))
    df_sorted = df.sort_values('completion_pct', ascending=False)
    bars = ax.barh(df_sorted['task_id'].astype(str), df_sorted['completion_pct'],
                   color=['green' if x == 100 else 'orange' for x in df_sorted['completion_pct']])
    ax.set_xlabel('Процент выполнения (%)')
    ax.set_title('Статус выполнения заказа')
    ax.grid(True, alpha=0.3)

    # add values on columns
    for bar in bars:
        width = bar.get_width()
        ax.text(width + 1, bar.get_y() + bar.get_height()/2, f"{width:.1f}",
                ha='left', va='center')
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