#!/usr/bin/env python3
"""
Скрипт для запуска всех тестов проекта
"""

import unittest
import sys
import os

def run_all_tests():
    """Запускает все тесты в проекте"""
    
    # Добавляем текущую директорию в путь
    sys.path.append(os.path.dirname(os.path.abspath(__file__)))
    
    # Находим все тесты
    test_loader = unittest.TestLoader()
    test_suite = test_loader.discover('tests', pattern='test_*.py')
    
    # Запускаем тесты
    test_runner = unittest.TextTestRunner(verbosity=2, stream=sys.stdout)
    result = test_runner.run(test_suite)
    
    # Возвращаем код выхода
    return 0 if result.wasSuccessful() else 1

if __name__ == '__main__':
    print("🧪 Запуск всех тестов EVM Dashboard...")
    exit_code = run_all_tests()
    sys.exit(exit_code)