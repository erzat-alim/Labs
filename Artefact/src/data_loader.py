import pandas as pd
from datetime import datetime

def load_project_data(file_path):
    
    df = pd.read_csv(file_path, parse_data=['start_date', 'end_date'])

    #data validation
    assert not df.empty
    assert all(col in df.columns for col in ['task_id', 'start_date', 'end_date', 'planned_cost', 'actual_cost', 'completion_pct'])
    
    return df

def validate_data(df):
    assert all((df['completion_pct']))
