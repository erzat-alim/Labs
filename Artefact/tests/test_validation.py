import unittest
import pandas as pd
import numpy as np
from datetime import datetime, timedelta
import sys
import os

sys.path.apppend(os.path.join(os.path.dirname(__file__), '..', 'src'))

from data_loader import load_project_data, validate_data
from evm_calculations import calculate_evm_metrics

class TestDataValidation(unittest.TestCase):
    #validation tests
    def setUp(self):
        self.base_date = {
            'task_id': [1, 2, 3, 4],
            'start_date': [datetime(2023, 1, 1), datetime(2023, 1, 5), 
                          datetime(2023, 1, 10), datetime(2023, 1, 15)],
            'end_date': [datetime(2023, 1, 10), datetime(2023, 1, 15),
                        datetime(2023, 1, 20), datetime(2023, 1, 25)],
            'planned_cost': [1000, 2000, 1500, 3000],
            'actual_cost': [900, 2100, 1400, 3200],
            'completion_pct': [100, 80, 50, 10]
        }
    def test_valid_data_loading(self):
        #valid loading test
        df = pd.DataFrame(self.base_date)

        #save and load for testing
        test_file = 'test_data.csv'
        df.to_csv(test_file, index=False)

        try:
            loaded_df = load_project_data(test_file)
            self.assertEqual(len(loaded_df), 4)
            self.assertTrue(validate_data(loaded_df))
        finally:
            if os.path.exists(test_file):
                os.remove(test_file)
    def test_empty_dataframe(self):
        df = pd.DataFrame()
        with self.assertRaises(AssertionError):
            load_project_data('nonexistent.csv')
    def test_missing_columns(self):
        incomplete_data = self.base_date.copy()
        del incomplete_data['task_id']
        df = pd.DataFrame(incomplete_data)

        test_file = 'test.incomplete.csv'
        df.to_csv(test_file, index=False)

        try:
            with self.assertRaises(AssertionError):
                load_project_data
        finally:
            if os.path.exists(test_file):
                os.remove(test_file)
    
