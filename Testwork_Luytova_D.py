"""
Задача №1. Написать программу для копирования массива.
"""
from copy import deepcopy


def array_copying(array: list) -> list:
    """
    Function for creating a copy of an array
    :param array: list for copying
    :return: copied list
    """
    new_list = deepcopy(array)
    return new_list


def test_array_copying():
    """
    Function for testing array_copying function
    """
    list1 = [1, 2, 3, 5]
    new_list1 = array_copying(list1)
    if list1 == new_list1:
        print('Test1 - ok')
    else:
        print('Test1 - failed')

    list2 = ['hello', 2, 'world', 5.87]
    new_list2 = array_copying(list2)
    if list2 == new_list2:
        print('Test2 - ok')
    else:
        print('Test3 - failed')

    list3 = [1, [34, 76], 'qwe', 8.23]
    new_list3 = array_copying(list3)
    if list3 == new_list3:
        print('Test3 - ok')
    else:
        print('Test3 - failed')

    list4 = []
    new_list4 = array_copying(list4)
    if list4 == new_list4:
        print('Test4 - ok')
    else:
        print('Test4 - failed')


test_array_copying()

"""Задача №2 с элементами математики. Написать программу для операции "произведение массивов". 
Сама операция определяется так, как будто элементы массива - это коэффициенты полинома. 
Соответственно, произведение массивов - должно дать новый массив, коэффициенты которого соответсвуют нужному полиному.

Например, возьмем полином (x - 1) и полином (x + 2). Их можно представить 
в виде массивов [-1, 1] и [2, 1] соответственно. 
Индекс элемента в массиве соответствует степени x при этом коээфициенте, т.е. полином (x - 1) можно переписать 
как (-1 * x^0 + 1 * x^1), таким образом соответсвующий этому полиному массив будет иметь вид [-1, 1].
По указанному правилу произведение массивов [-1, 1] и [2, 1] 
должно быть равно [-2, 1, 1], т.к. (x - 1) * (x + 2) = (x^2 + x^1 - 2).
"""

import numpy as np

def product_of_arrays(list1: list, list2: list) -> list:
    """
    Function for multiplying two lists
    :param list1: list1 for multiplying
    :param list2: list2 for multiplying
    :return: new_list - the result of two lists multiplication
    """
    new_list = np.zeros(len(list1) + len(list2) - 1, dtype=int)

    for i in range(len(list1)):
        for j in range(len(list2)):
            new_list[i + j] += list1[i] * list2[j]

    return new_list.tolist()

def test_product_of_arrays():
    """
    Function for testing product_of_arrays function
    """
    list1 = [1, 2, 3, 5]
    list2 = [0]
    new_list1 = product_of_arrays(list1, list2)
    if new_list1 == [0, 0, 0, 0]:
        print('Test1 - ok')
    else:
        print('Test1 - failed')

    list3 = [1, 2, 3, 5]
    list4 = [-3, -1, -7]
    new_list2 = product_of_arrays(list3, list4)
    if new_list2 == [-3, -7, -18, -32, -26, -35]:
        print('Test2 - ok')
    else:
        print('Test2 - failed')


    list5 = [12, 23]
    list6 = [2, 0, -7]
    new_list3 = product_of_arrays(list5, list6)
    if new_list3 == [24, 46, -84, -161]:
        print('Test2 - ok')
    else:
        print('Test2 - failed')


test_product_of_arrays()