def copy_list(array: list):
    """
    Задача 1. Функция копирования списка
    """
    try:
        return array.copy()
    except AttributeError:
        return "Invalid data format"


def multiply_polynomial(first_polynomial: list, second_polynomial: list):
    """
    Задача 2. Функция умножения списков
    """
    try:
        res = [0] * (len(first_polynomial) + len(second_polynomial) - 1)
        for i, x in enumerate(first_polynomial):
            for j, y in enumerate(second_polynomial):
                res[i + j] += x * y
        return res
    except Exception as e:
        return "Invalid data formatх", e