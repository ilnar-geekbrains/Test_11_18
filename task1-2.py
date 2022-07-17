from copy import deepcopy
from numpy import convolve

# Решение Задачи 1, способ 1
# Используя deepcopy. Позволит полностью скопировать и вложенные списки
def copy_array(input_array):
    copied_array = deepcopy(input_array)
    return copied_array

# Решение Задачи 1, способ 2
# Подойдет для копирования списка, без вложений.
def copy_array(input_array):
    copied_array = [element for element in input_array]
    return copied_array

# Решение Задачи 1, способ 3
# Позволяет копировать вложенные списки
def copy_array(input_array):
    copied_array = []
    for element in input_array:
        if isinstance(element, list):
            copied_array.append(copy_array(element))
        else:
            copied_array.append(element)
    return copied_array

# Решение Задачи 2, способ 1
# Cамый оптимальный.
# Используем готовую функцию в NumPy
def polynomial_multiply(array1, array2):
    result = list(np.convolve(array1, array2))
    return result

# Решение Задачи 2, 2 способ.
# Так же используем библиотеку NumPy.
# Создадим результатирующий массив, заполненный нулями
# Умножим один полином на второй и добавим в список.
def polynomial_multiply(array1, array2):
    array_result = np.zeros(len(array1) + len(array2) - 1, dtype=int)
    for i in range(len(array1)):
        for j in range(len(array2)):
            array_result[i + j] += array1[i] * array2[j]
    result = list(array_result)
    return result

# Решение Задачи 2, 3 способ
# Исключим NumPy
def polynomial_multiply(array1, array2):
  array_result = [0] * (len(array1) + len(array2) - 1)
  for i in range(len(array1)):
    for j in range(len(array2)):
      array_result[j + i] += array1[i] * array2[j]
  return array_result



def test1():
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

def test2():
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


def main():
    test1()
    test2()

if __name__ == '__main__':
    main()
