# Номер задания 1. Напишите программу для копирования массива.

def copy_array_shallow(arr):
    """Эта функция копирует массив, используя встроенный метод поверхностного копирования."""
    return arr[:]  # or arr.copy()

def copy_array_shallow_iter(arr):
    """Эта функция копирует массив, используя list comprehension."""
    return [x for x in arr]


def copy_array_deep(arr):
    """Эта функция копирует массив, используя рекурсивный метод.
       Для простоты, копируем только списки с простыми типами данных.
    """
    result = []
    for item in arr:
        if isinstance(item, list):
            arr_copy = copy_array_deep(item)
            result.append(arr_copy)
        else:
            result.append(item)
    return result

def is_arrays_equal(arr1, arr2):
    """Эта функция проверяет, если два массива равны.
       Для простоты, проверяем списки с простыми типами данных.
    """
    if len(arr1) != len(arr2):
        return False
    for i in range(len(arr1)):
        if arr1[i] != arr2[i]:
            return False
        if isinstance(arr1[i], list) and isinstance(arr2[i], list):
            if not is_arrays_equal(arr1[i], arr2[i]):
                return False
    return True


def test_is_arrays_equal():
    """Эта функция проверяет функцию is_arrays_equal."""
    arr1 = [1, 2, 3, 5]
    arr2 = [1, 2, 3, 5]
    assert is_arrays_equal(arr1, arr2), "The arrays are not equal."
    arr2[0] = 0
    assert not is_arrays_equal(arr1, arr2), "The arrays are equal."
    arr2 = [1, 2, 3, [4, 5, 6, [10, 11]]]
    assert not is_arrays_equal(arr1, arr2), "The arrays are equal."
    arr2[3][0] = 0
    assert not is_arrays_equal(arr1, arr2), "The arrays are equal."
    arr2 = [1, 2, 3, [4, 5, 6, [10, 11]]]
    arr3 = [1, 2, 3, [4, 5, 6, [10, 11]]]
    assert is_arrays_equal(arr2, arr3), "The arrays are not equal."


def test_copy_array(copy_func, is_deep=False):
    """Эта функция проверяет функцию copy_array_shallow."""
    arr = [1, 2, 3, 5]
    arr_copy = copy_func(arr)
    assert is_arrays_equal(arr, arr_copy), "The arrays are not equal."
    assert is_arrays_equal(arr_copy, arr), "The arrays are not equal."
    arr_copy[0] = 0
    assert arr[0] == 1, "The arrays are not equal."

    # test deep copy with recursion
    arr = [1, 2, 3, [4, 5, 6, [10, 11]]]
    arr_copy = copy_func(arr)
    assert is_arrays_equal(arr, arr_copy), "The arrays are not equal."
    assert is_arrays_equal(arr_copy, arr), "The arrays are not equal."

    if is_deep:
        arr_copy[3][0] = 0
        assert arr[3][0] == 4, "The arrays are not equal."
        arr_copy[3][3][0] = 0
        assert arr[3][3][0] == 10, "The arrays are not equal."
    else:
        arr_copy[3][0] = 0
        assert arr[3][0] == 0, "The arrays are not equal."
        arr_copy[3][3][0] = 0
        assert arr[3][3][0] == 0, "The arrays are not equal."


if __name__ == '__main__':
    print("Testing test_is_arrays_equal():")
    test_is_arrays_equal()
    print("OK")
    print("Test copy_array_shallow(): ", end="")
    test_copy_array(copy_array_shallow)
    print("OK")
    print("Test copy_array_shallow_iter(): ", end="")
    test_copy_array(copy_array_shallow_iter)
    print("OK")
    print("Test copy_array_deep() ", end="")
    test_copy_array(copy_array_deep, True)
    print("OK")


