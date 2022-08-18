from task_1 import copyofDeepCopy
from task_2 import arraysProduct
import sys

def test_task_1():
    """
    Процедура для проверки решения задачи 1.
    """
    array = [1, 2, 'a', (True, 1.1), [1, 2, False]]
    array2 = copyofDeepCopy(array)
    
    assert array is not array2 # id разные
    assert array[-1] is not array2[-1] # для изменяемых создаётся новый инстанс
    
    assert array[1] is not array2[1] # а вот тут был неизменяемый объект
    # неизменяемые объекты нет смысла дублировать, так что тут должна быть ошибка, всё ок

    # assert array[-1][1] is not array2[-1][1]
    # это тоже вызвало было ошибку, потому что внутри нового списка ссылка на тот же неизменяемый объект

def test_task_2():
    """
    Процедура для проверки решения задачи 2.
    Решения получал с помощью https://www.math-solution.ru/math-task/simplifi-polynom
    """
    coefs = [[[-1, 1], [2, 1]],
             [[-3, 1], [2, 1]],
             [[-3, 2], [2, 4], [-2, 2, 1]],
             [[-1, 0, 1], [2, 1, 0, 3], [14, 11, 10, 0, -4]],
            ]
    expected_answers = [[-2, 1, 1],
                    [-6, -1, 1],
                    [12, 4, -38, 8, 8],
                    [-28, -36, -3, -16, 6, 26, 25, 38, 0, -12]
                   ]
    
    print('Проверка на четырёх тестах: ', end='')
    for pols, expected_answer in zip(coefs, expected_answers):
        answer = arraysProduct(*pols)
        assert answer == expected_answer

        sys.stdout.write('OK ')
        sys.stdout.flush()
    
    print('\nВсё ок)')
