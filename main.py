from copy import deepcopy

def copy_array(array: list) -> list:
    """
    Задача №1. Копирования массива
    """
    return deepcopy(array)


def multiply_polinomials(polinomial_1: list, polinomial_2: list) -> list:
    """
    Задача №2. Произведение массивов
    """
    if not all(isinstance(i, int) for i in polinomial_1 + polinomial_2):
        raise ValueError("Invalid polinomial")

    res = [0]*(len(polinomial_1)+len(polinomial_2)-1)
    for i1, n1 in enumerate(polinomial_1):
        for i2, n2 in enumerate(polinomial_2):
            res[i1 + i2] += n1 * n2
    return res

