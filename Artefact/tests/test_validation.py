import unittest
import pandas as pd
import numpy as np
from datetime import datetime, timedelta
import sys
import os

# Добавляем путь к src для импорта модулей
sys.path.append(os.path.join(os.path.dirname(__file__), '..', 'src'))

from data_loader import load_project_data, validate_data
from evm_calculations import calculate_evm_metrics

class TestDataValidation(unittest.TestCase):
    """Тесты для валидации данных"""
    
    def setUp(self):
        """Создаем тестовые данные"""
        self.base_data = {
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
        """Тест загрузки корректных данных"""
        df = pd.DataFrame(self.base_data)
        
        # Сохраняем и загружаем для теста
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
        """Тест пустого DataFrame"""
        with self.assertRaises(FileNotFoundError):  # ИЗМЕНЕНО НА FileNotFoundError
            load_project_data('nonexistent.csv')
    
    def test_missing_columns(self):
        """Тест отсутствующих колонок"""
        incomplete_data = self.base_data.copy()
        del incomplete_data['task_id']  # Удаляем обязательную колонку
        df = pd.DataFrame(incomplete_data)
        
        test_file = 'test_incomplete.csv'
        df.to_csv(test_file, index=False)
        
        try:
            with self.assertRaises(AssertionError):  # ДОЛЖНО ВЫЗВАТЬ AssertionError
                load_project_data(test_file)
        finally:
            if os.path.exists(test_file):
                os.remove(test_file)
    
    def test_completion_percentage_boundaries(self):
        """Тест граничных значений процента выполнения"""
        test_cases = [
            (-5, False),  # отрицательное значение
            (0, True),    # минимальное корректное
            (50, True),   # среднее значение
            (100, True),  # максимальное корректное
            (105, False), # превышение максимума
        ]
        
        for completion_pct, should_pass in test_cases:
            with self.subTest(completion_pct=completion_pct):
                test_data = self.base_data.copy()
                test_data['completion_pct'] = [100, 80, completion_pct, 10]
                df = pd.DataFrame(test_data)
                
                if should_pass:
                    self.assertTrue(validate_data(df))
                else:
                    with self.assertRaises(AssertionError):
                        validate_data(df)
        
        # ОТДЕЛЬНЫЙ ТЕСТ ДЛЯ NaN
        test_data = self.base_data.copy()
        test_data['completion_pct'] = [100, 80, float('nan'), 10]
        df = pd.DataFrame(test_data)
        with self.assertRaises(AssertionError):
            validate_data(df)
    
    def test_date_validation(self):
        """Тест валидации дат"""
        test_cases = [
            (datetime(2023, 1, 1), datetime(2023, 1, 10), True),  # корректные даты
            (datetime(2023, 1, 10), datetime(2023, 1, 1), False), # дата окончания раньше начала
            (datetime(2023, 1, 1), datetime(2023, 1, 1), True),   # одинаковые даты
        ]
        
        for start_date, end_date, should_pass in test_cases:
            with self.subTest(start_date=start_date, end_date=end_date):
                test_data = self.base_data.copy()
                test_data['start_date'] = [start_date] * 4
                test_data['end_date'] = [end_date] * 4
                df = pd.DataFrame(test_data)
                
                if should_pass:
                    self.assertTrue(validate_data(df))
                else:
                    with self.assertRaises(AssertionError):
                        validate_data(df)
    
    def test_cost_validation(self):
        """Тест валидации стоимостей"""
        test_cases = [
            (-100, False),  # отрицательная стоимость
            (0, True),      # нулевая стоимость
            (1000, True),   # положительная стоимость
            (1e6, True),    # большая стоимость
        ]
        
        for cost, should_pass in test_cases:
            with self.subTest(cost=cost):
                test_data = self.base_data.copy()
                test_data['planned_cost'] = [cost] * 4
                test_data['actual_cost'] = [cost] * 4
                df = pd.DataFrame(test_data)
                
                if should_pass:
                    self.assertTrue(validate_data(df))
                else:
                    with self.assertRaises(AssertionError):
                        validate_data(df)

class TestEVMCalculations(unittest.TestCase):
    """Тесты для расчетов EVM метрик"""
    
    def setUp(self):
        """Создаем тестовые данные для расчетов"""
        self.report_date = datetime(2023, 1, 15)
        
        self.test_cases = {
        'ideal_project': {
            'data': {
                'task_id': [1, 2],
                'start_date': [datetime(2023, 1, 1), datetime(2023, 1, 5)],
                'end_date': [datetime(2023, 1, 10), datetime(2023, 1, 15)],
                'planned_cost': [1000, 2000],
                'actual_cost': [1000, 2000],
                'completion_pct': [100, 100]
            },
            'expected': {'CPI': 1.0, 'SPI': 1.0, 'CV': 0.0, 'SV': 0.0}
        },
        'over_budget_project': {
            'data': {
                'task_id': [1, 2],
                'start_date': [datetime(2023, 1, 1), datetime(2023, 1, 5)],
                'end_date': [datetime(2023, 1, 10), datetime(2023, 1, 15)],
                'planned_cost': [1000, 2000],
                'actual_cost': [1500, 2500],
                'completion_pct': [100, 100]
            },
            'expected': {'CPI': 0.75, 'SPI': 1.0, 'CV': -1000.0, 'SV': 0.0}  # ИСПРАВЛЕНО
        },
        'behind_schedule_project': {
            'data': {
                'task_id': [1, 2],
                'start_date': [datetime(2023, 1, 1), datetime(2023, 1, 5)],
                'end_date': [datetime(2023, 1, 10), datetime(2023, 1, 15)],
                'planned_cost': [1000, 2000],
                'actual_cost': [1000, 2000],
                'completion_pct': [50, 50]
            },
            'expected': {'CPI': 1.0, 'SPI': 0.5, 'CV': 0.0, 'SV': -1500.0}
        }
    }
    
    def test_evm_calculations_ideal_case(self):
        """Тест расчетов для идеального проекта"""
        case = self.test_cases['ideal_project']
        df = pd.DataFrame(case['data'])
        metrics = calculate_evm_metrics(df, self.report_date)
        
        self.assertAlmostEqual(metrics['CPI'], case['expected']['CPI'], places=2)
        self.assertAlmostEqual(metrics['SPI'], case['expected']['SPI'], places=2)
        self.assertAlmostEqual(metrics['CV'], case['expected']['CV'], places=2)
        self.assertAlmostEqual(metrics['SV'], case['expected']['SV'], places=2)
    
    def test_evm_calculations_over_budget(self):
        """Тест расчетов для проекта с перерасходом"""
        case = self.test_cases['over_budget_project']
        df = pd.DataFrame(case['data'])
        metrics = calculate_evm_metrics(df, self.report_date)
        
        self.assertAlmostEqual(metrics['CPI'], case['expected']['CPI'], places=2)
        self.assertAlmostEqual(metrics['CV'], case['expected']['CV'], places=2)
        self.assertLess(metrics['CPI'], 1.0)  # CPI должен быть < 1
    
    def test_evm_calculations_behind_schedule(self):
        """Тест расчетов для отстающего проекта"""
        case = self.test_cases['behind_schedule_project']
        df = pd.DataFrame(case['data'])
        metrics = calculate_evm_metrics(df, self.report_date)
        
        self.assertAlmostEqual(metrics['SPI'], case['expected']['SPI'], places=2)
        self.assertAlmostEqual(metrics['SV'], case['expected']['SV'], places=2)
        self.assertLess(metrics['SPI'], 1.0)  # SPI должен быть < 1
    
    def test_edge_case_empty_tasks(self):
        """Тест с пустым списком задач на отчетную дату"""
        df = pd.DataFrame({
            'task_id': [1],
            'start_date': [datetime(2023, 2, 1)],  # все задачи после отчетной даты
            'end_date': [datetime(2023, 2, 10)],
            'planned_cost': [1000],
            'actual_cost': [0],
            'completion_pct': [0]
        })
        
        metrics = calculate_evm_metrics(df, self.report_date)
        
        # Все метрики должны быть 0, кроме BAC
        self.assertEqual(metrics['PV'], 0)
        self.assertEqual(metrics['EV'], 0)
        self.assertEqual(metrics['AC'], 0)
        self.assertEqual(metrics['CPI'], 0)
        self.assertEqual(metrics['SPI'], 0)
    
    def test_edge_case_single_day_task(self):
        """Тест задачи длительностью в один день"""
        df = pd.DataFrame({
            'task_id': [1],
            'start_date': [datetime(2023, 1, 15)],
            'end_date': [datetime(2023, 1, 15)],
            'planned_cost': [1000],
            'actual_cost': [1000],
            'completion_pct': [100]
        })
        
        metrics = calculate_evm_metrics(df, self.report_date)
        
        # PV должна быть равна полной стоимости
        self.assertEqual(metrics['PV'], 1000)
        self.assertEqual(metrics['EV'], 1000)
    
    def test_edge_case_zero_costs(self):
        """Тест с нулевыми стоимостями"""
        df = pd.DataFrame({
            'task_id': [1, 2],
            'start_date': [datetime(2023, 1, 1), datetime(2023, 1, 5)],
            'end_date': [datetime(2023, 1, 10), datetime(2023, 1, 15)],
            'planned_cost': [0, 0],
            'actual_cost': [0, 0],
            'completion_pct': [100, 100]
        })
        
        metrics = calculate_evm_metrics(df, self.report_date)
        
        # Проверяем обработку деления на ноль
        self.assertTrue(np.isfinite(metrics['CPI']))
        self.assertTrue(np.isfinite(metrics['SPI']))
    
    def test_edge_case_very_large_numbers(self):
        """Тест с очень большими числами"""
        df = pd.DataFrame({
            'task_id': [1],
            'start_date': [datetime(2023, 1, 1)],
            'end_date': [datetime(2023, 1, 10)],
            'planned_cost': [1e9],
            'actual_cost': [1.1e9],
            'completion_pct': [100]
        })
        
        metrics = calculate_evm_metrics(df, self.report_date)
        
        # Проверяем что расчеты работают с большими числами
        self.assertAlmostEqual(metrics['CPI'], 0.91, places=2)  # 1e9 / 1.1e9 ≈ 0.909
        self.assertAlmostEqual(metrics['CV'], -1e8, places=2)

class TestIntegration(unittest.TestCase):
    """Интеграционные тесты"""
    
    def test_end_to_end_workflow(self):
        """Тест полного workflow: загрузка → валидация → расчет → отчет"""
        # Создаем тестовые данные
        test_data = {
            'task_id': [1, 2, 3],
            'start_date': [datetime(2023, 1, 1), datetime(2023, 1, 5), datetime(2023, 1, 10)],
            'end_date': [datetime(2023, 1, 10), datetime(2023, 1, 15), datetime(2023, 1, 20)],
            'planned_cost': [1000, 2000, 3000],
            'actual_cost': [900, 2100, 1500],
            'completion_pct': [100, 80, 50]
        }
        
        df = pd.DataFrame(test_data)
        test_file = 'test_integration.csv'
        df.to_csv(test_file, index=False)
        
        try:
            # Загрузка и валидация
            loaded_df = load_project_data(test_file)
            self.assertTrue(validate_data(loaded_df))
            
            # Расчет метрик
            report_date = datetime(2023, 1, 15)
            metrics = calculate_evm_metrics(loaded_df, report_date)
            
            # Проверяем что все метрики рассчитаны
            required_metrics = ['PV', 'EV', 'AC', 'CPI', 'SPI', 'EAC', 'ETC']
            for metric in required_metrics:
                self.assertIn(metric, metrics)
                self.assertTrue(np.isfinite(metrics[metric]))
                
        finally:
            if os.path.exists(test_file):
                os.remove(test_file)

if __name__ == '__main__':
    # Создаем test runner с детальным выводом
    runner = unittest.TextTestRunner(verbosity=2)
    
    # Создаем test suite
    suite = unittest.TestSuite()
    suite.addTest(unittest.makeSuite(TestDataValidation))
    suite.addTest(unittest.makeSuite(TestEVMCalculations))
    suite.addTest(unittest.makeSuite(TestIntegration))
    
    # Запускаем тесты
    print("🚀 Запуск валидационных тестов...")
    result = runner.run(suite)
    
    # Выводим итоги
    print(f"\n📊 Результаты тестов:")
    print(f"✅ Пройдено: {result.testsRun - len(result.failures) - len(result.errors)}")
    print(f"❌ Провалено: {len(result.failures)}")
    print(f"⚠️ Ошибок: {len(result.errors)}")
    
    if result.failures:
        print(f"\n❌ Проваленные тесты:")
        for test, traceback in result.failures:
            print(f"   - {test}")
    
    if result.errors:
        print(f"\n⚠️ Тесты с ошибками:")
        for test, traceback in result.errors:
            print(f"   - {test}")