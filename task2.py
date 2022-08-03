def polynomial_multiply(array1, array2):
    """Умножение массивов"""
    array_result = [0] * (len(array1) + len(array2) - 1)
    for i in range(len(array1)):
        for j in range(len(array2)):
            array_result[j + i] += array1[i] * array2[j]
    return array_result


if __name__ == '__main__':
    test_arrays = [
        [[-1, 1], [2, 1]],
        [[1, 6, 3], [2, 5, 6, 9]],
        [[6, 2, 3, -2], [-1, -2, -3]],
        [[-2, -1, 1, 2], [2, 3, 4, 5, 9]]
    ]
    test_result = [
        [-2, 1, 1],
        [2, 17, 42, 60, 72, 27],
        [-6, -14, -25, -10, -5, 6],
        [-4, -8, -9, -7, -13, 4, 19, 18]
    ]
    for elem in range(len(test_arrays)):
        assert polynomial_multiply(*test_arrays[elem]) == test_result[elem]
    print('Тесты пройдены')
