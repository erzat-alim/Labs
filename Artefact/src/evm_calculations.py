import pandas as pd
from datetime import datetime
import numpy as np

# УДАЛИТЕ ЭТУ СТРОКУ - она вызывает циклический импорт
# from evm_calculations import calculate_evm_metrics

def calculate_evm_metrics(df, report_date):
    # Фильтруем задачи, которые уже начались
    relevant_tasks = df[df['start_date'] <= report_date].copy()
    
    # ЕСЛИ НЕТ РЕЛЕВАНТНЫХ ЗАДАЧ - ВОЗВРАЩАЕМ НУЛЕВЫЕ МЕТРИКИ
    if len(relevant_tasks) == 0:
        return {
            'report_date': report_date,
            'PV': 0, 'EV': 0, 'AC': 0, 'CV': 0, 'SV': 0,
            'CPI': 0, 'SPI': 0, 'BAC': df['planned_cost'].sum(),
            'EAC': df['planned_cost'].sum(), 'ETC': df['planned_cost'].sum(), 'VAC': 0
        }
    
    # Расчет PV (Planned Value) - ИСПРАВЛЕННАЯ ЛОГИКА
    def calculate_pv(row):
        if row['end_date'] <= report_date:
            # Задача должна быть завершена к отчетной дате
            return row['planned_cost']
        else:
            # Задача еще не завершена, рассчитываем по прогрессу времени
            total_days = (row['end_date'] - row['start_date']).days
            if total_days == 0:
                return row['planned_cost']  # Задача длится 0 дней - вся стоимость
            elapsed_days = (report_date - row['start_date']).days
            progress = min(max(elapsed_days / total_days, 0), 1)  # Ограничиваем от 0 до 1
            return row['planned_cost'] * progress
    
    # ИСПРАВЛЕНИЕ: Применяем функцию к каждой строке отдельно
    relevant_tasks['pv'] = relevant_tasks.apply(calculate_pv, axis=1)
    relevant_tasks['ev'] = relevant_tasks['planned_cost'] * relevant_tasks['completion_pct'] / 100
    relevant_tasks['ac'] = relevant_tasks['actual_cost']

    # Суммируем метрики
    t_pv = relevant_tasks['pv'].sum()
    t_ev = relevant_tasks['ev'].sum()
    t_ac = relevant_tasks['ac'].sum()

    # Рассчитываем отклонения и индексы
    cv = t_ev - t_ac
    sv = t_ev - t_pv
    cpi = t_ev / t_ac if t_ac != 0 else 1
    spi = t_ev / t_pv if t_pv != 0 else 1

    # Прогнозные метрики
    bac = df['planned_cost'].sum()
    eac = bac / cpi if cpi > 0 else bac
    etc = eac - t_ac
    vac = bac - eac

    return {
        'report_date': report_date,
        'PV': round(t_pv, 2),
        'EV': round(t_ev, 2),
        'AC': round(t_ac, 2),
        'CV': round(cv, 2),
        'SV': round(sv, 2),
        'CPI': round(cpi, 2),
        'SPI': round(spi, 2),
        'BAC': round(bac, 2),
        'EAC': round(eac, 2),
        'ETC': round(etc, 2),
        'VAC': round(vac, 2),
    }