import random


def copy_array_1(arr):
    """Вернуть копию списка срезом"""
    return arr[:]


def copy_array_2(arr):
    """Вернуть копию списка с помощью встроенной функцией"""
    new_arr = arr.copy()
    return new_arr


def copy_array_3(arr):
    """Вернуть копию списка перебрав оригинальный"""
    new_arr = [elem for elem in arr]
    return new_arr


if __name__ == '__main__':
    # 20 случайных чисел от 0 до 999
    old_arr = random.sample(range(1000), 20)

    # делам три варианта копирования списка
    new_arr_1 = copy_array_1(old_arr)
    new_arr_2 = copy_array_2(old_arr)
    new_arr_3 = copy_array_3(old_arr)

    # тесты на то, что содержимое совпадает
    assert old_arr == new_arr_1
    assert old_arr == new_arr_2
    assert old_arr == new_arr_3
    print('Содержимое совпадает')

    # тесты проверяют, что была возвращена именно копия, а не тот же объект
    assert id(old_arr) != id(new_arr_1)
    assert id(old_arr) != id(new_arr_2)
    assert id(old_arr) != id(new_arr_3)
    print('Все объекты списков являются копиями')
