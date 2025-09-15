import pandas as pd
from datetime import datetime

def calculate_evm_metrics(df, report_date):
    relevant_tasks = df[df['start_date'] <= report_date].copy()

    relevant_tasks['pv'] = relevant_tasks.apply(
        lambda x: x['planned_cost'] if x['end_date'] <= report_date
        else x['planned_cost'] * (report_date - x['start_date']).days /
        (x['end_date'] - x['start_date']).days,
        axis=1
    )
    relevant_tasks['ev'] = relevant_tasks['planned_cost'] * relevant_tasks['completion_pct'] /100
    relevant_tasks['ac'] = relevant_tasks['actual_cost']

    t_pv = relevant_tasks['pv'].sum()
    t_ev = relevant_tasks['ev'].sum()
    t_ac = relevant_tasks['ac'].sum()

    cv = t_ev - t_ac
    sv = t_ev - t_pv
    cpi = t_ev / t_ac if t_ac != 0 else 0
    spi = t_ev / t_pv if t_pv != 0 else 0

    bac = df['planned_cost'].sum()
    eac = bac / cpi if cpi != 0 else bac
    etc = eac - t_ac
    vac = bac - eac

    return {
        'report_date': report_date,
        'PV': t_pv,
        'EV': t_ev,
        'AC': t_ac,
        'CV': cv,
        'SV': sv,
        'CPI': cpi,
        'SPI': spi,
        'BAC': bac,
        'EAC': eac,
        'ETC': etc,
        'VAC': vac,
    }