def copy_array(array: list):
    """
    Задача 1. Функция для копирования массива
    """
    try:
        return array.copy()
    except AttributeError:
        return "Неверный формат данных"


def multiply_arrays(first_arr: list, second_arr: list):
    """
    Задача 2. Функция для умножения массивов
    """
    try:
        n, m = len(first_arr), len(second_arr)
        res = [0] * (n + m - 1)
        for i in range(n):
            for j in range(m):
                res[i + j] += first_arr[i] * second_arr[j]
        return res
    except Exception as e:
        return "Неверный формат данных", e
