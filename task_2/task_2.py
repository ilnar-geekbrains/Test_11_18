def multiply_arrays(array1: list, array2: list):
    """
    The multiplying function of two arrays.

    :param array1: the first array
    :type array1: list
    :param array2: the second array
    :type array2: list
    :return: output array
    :rtype: list
    """

    # словарь, где ключами являются суммы степеней перемножаемых членов полинома,
    # а значение – произведение коэффициентов этих членов:
    result = {}
    for i_1, k_1 in enumerate(array1):
        for i_2, k_2 in enumerate(array2):
            result[i_1 + i_2] = result.setdefault(i_1 + i_2, 0) + k_1 * k_2

    return list(result.values())


if __name__ == '__main__':
    pass
