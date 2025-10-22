import pandas as pd
from datetime import datetime
import os  # ДОБАВИТЬ ЭТОТ ИМПОРТ

def load_project_data(file_path):
    # ДОБАВИТЬ ПРОВЕРКУ СУЩЕСТВОВАНИЯ ФАЙЛА
    if not os.path.exists(file_path):
        raise FileNotFoundError(f"Файл {file_path} не найден")
    
    df = pd.read_csv(file_path, parse_dates=['start_date', 'end_date'])

    # data validation
    assert not df.empty, "DataFrame не должен быть пустым"  # ДОБАВИТЬ СООБЩЕНИЕ
    required_columns = ['task_id', 'start_date', 'end_date', 'planned_cost', 'actual_cost', 'completion_pct']
    assert all(col in df.columns for col in required_columns), f"Отсутствуют обязательные колонки: {required_columns}"  # ДОБАВИТЬ СООБЩЕНИЕ
    
    return df

def validate_data(df):
    # ДОБАВИТЬ ПРОВЕРКУ НА NaN ЗНАЧЕНИЯ
    assert not df['completion_pct'].isna().any(), "completion_pct не может содержать NaN значения"
    
    assert all((df['completion_pct'] >= 0) & (df['completion_pct'] <= 100)), "completion_pct должен быть от 0 до 100"  # ДОБАВИТЬ СООБЩЕНИЕ
    assert all(df['start_date'] <= df['end_date']), "start_date не может быть больше end_date"  # ДОБАВИТЬ СООБЩЕНИЕ
    assert all(df['planned_cost'] >= 0), "planned_cost не может быть отрицательным"  # ДОБАВИТЬ СООБЩЕНИЕ
    assert all(df['actual_cost'] >= 0), "actual_cost не может быть отрицательным"  # ДОБАВИТЬ СООБЩЕНИЕ

    return True