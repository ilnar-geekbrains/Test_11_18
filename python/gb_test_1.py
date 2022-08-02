# Задача №1. Написать программу для копирования массива.
from copy import deepcopy


def make_copy_array(input_array: list) -> list:
    """
    Функция создаёт копию входящего списка/массива.
    :param input_array: входящий список.
    :return: исходящий список - копия входящего.
    """
    return deepcopy(input_array)


if __name__ == '__main__':
    test_array = [
        [1, 2, 3],
        [4, 5, 6],
        [7, 8, 9]
    ]
    try:
        print(make_copy_array(test_array))
    except Exception as e:
        print(e)
