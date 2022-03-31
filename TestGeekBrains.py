from copy import deepcopy


def copy_arr(arr):
    arr_repeat = deepcopy(arr)
    return arr_repeat, arr


def arr_composition(arr_first, arr_second):
    # Думал об использовании FFT, остановился на этом варианте из-за погрешностей, все-таки С-подобные языки
    # лучше работают с вещественными и комплексными числами
    # Создание результирующего списка на определенное кол-во элементов
    result_arr = [0 for i in range(len(arr_first) + len(arr_second) - 1)]

    # Умножаем все элементы первого полинома на каждый элемент второго полинома
    # И сохраняем все в конечный список
    for i in range(len(arr_first)):
        for j in range(len(arr_second)):
            result_arr[i + j] += arr_first[i] * arr_second[j]

    # Возвращаем результат программы
    return result_arr


# Тестирование работы программы (Задача 1)
if copy_arr([1, 5, 0, 9, 2]) == ([1, 5, 0, 9, 2], [1, 5, 0, 9, 2]):
    print('Тест пройден')
else:
    print('Тест провален')

if copy_arr([1, 5, 0, 9, 2]) == ([1, 5, 0, 9, 2], [1, 5, 0, 9, 2]):
    # Этот тест позволяет нам понять, что мы скопировали все содержимого первого массива
    # и перенесли во второй, а не просто создали новую ссылку на предыдущий массив
    array = copy_arr([1, 5, 0, 9, 2])[0]
    array.append(2)
    if array != array[1]:
        print('Тест пройден')
    else:
        print('Тест провален')

# Тестирование работы программы (Задача 2)
if arr_composition([-1, 1], [2, 1]) == [-2, 1, 1]:
    print('Тест пройден')
else:
    print('Тест провален')

if arr_composition([-9, 7, 1, 5], [1, 1]) == [-9, -2, 8, 6, 5]:
    print('Тест пройден')
else:
    print('Тест провален')

if arr_composition([0, 7, 6], [5, 11, 4]) == [3, 8, 5]:
    print('Тест пройден')
else:
    print(arr_composition([0, 7, 6], [5, 11, 4]))
    print('Тест провален')

if arr_composition([14, 0, 5, -1], [7, 2, 8]) == [98, 28, 147, 3, 38, -8]:
    print('Тест пройден')
else:
    print('Тест провален')

if arr_composition([0, 0], [0, 0]) == [0, 0, 0]:
    print('Тест пройден')
else:
    print('Тест провален')
