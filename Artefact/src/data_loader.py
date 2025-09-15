import pandas as pd
from datetime import datetime

def load_project_data(file_path):
    
    df = pd.read_csv(file_path, parse_dates=['start_date', 'end_date'])

    #data validation
    assert not df.empty
    assert all(col in df.columns for col in ['task_id', 'start_date', 'end_date', 'planned_cost', 'actual_cost', 'completion_pct'])
    
    return df

def validate_data(df):
    assert all((df['completion_pct'] >= 0) & (df['completion_pct'] <= 100))
    assert all(df['start_date'] <= df['end_date'])
    assert all(df['planned_cost'] >= 0)
    assert all(df['actual_cost'] >= 0)

    return True
