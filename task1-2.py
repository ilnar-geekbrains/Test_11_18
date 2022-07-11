from copy import deepcopy
from numpy import convolve

# deepcopy позволит полностью скопировать и вложенные списки
def copy_array(input_array):
    copied_array = deepcopy(input_array)
    return copied_array

# для решения этой задачи, что бы не изобретать велосипед, оптимально подойдет numpy
def polynomial_multiply(array1, array2):
    result = list(convolve(array1, array2))
    return result

# Тестирование работы программы (Задача 1)
if copy_array([1, 5, 0, 9, 2]) == [1, 5, 0, 9, 2]:
    print('Тест пройден')
else:
    print('Тест провален')

if copy_array([1, 5, 0, 9, 2]) ==  [1, 5, 0, 9, 2]:
    # Этот тест позволяет нам понять, что мы скопировали все содержимого первого массива
    # и перенесли во второй, а не просто создали новую ссылку на предыдущий массив
    array = copy_array([1, 5, 0, 9, 2])
    array.append(2)
    if array != [1, 5, 0, 9, 2]:
        print('Тест пройден')
    else:
        print('Тест провален')


# Тестирование работы программы (Задача 2)
if polynomial_multiply([-1, 1], [2, 1]) == [-2, 1, 1]:
    print('Тест пройден')
else:
    print('Тест провален')

if polynomial_multiply([-9, 7, 1, 5], [1, 1]) == [-9, -2, 8, 6, 5]:
    print('Тест пройден')
else:
    print('Тест провален')

if polynomial_multiply([0, 7, 6], [5, 11, 4]) == [0, 35, 107,94,24]:
    print('Тест пройден')
else:
    print(polynomial_multiply([0, 7, 6], [5, 11, 4]))
    print('Тест провален')

if polynomial_multiply([14, 0, 5, -1], [7, 2, 8]) == [98, 28, 147, 3, 38, -8]:
    print('Тест пройден')
else:
    print('Тест провален')

if polynomial_multiply([0, 0], [0, 0]) == [0, 0, 0]:
    print('Тест пройден')
else:
    print('Тест провален')
