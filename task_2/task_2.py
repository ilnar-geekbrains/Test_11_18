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


def main_func(*args: list) -> list:
    """
    The function of looping through arrays and calling the multiply arrays function

    :param args: arrays
    :type args: list
    :return: the result of multiping
    :rtype: list
    """

    first_mult = args[0]
    for second_mult in args[1:]:
        first_mult = multiply_arrays(first_mult, second_mult)
    return first_mult


if __name__ == '__main__':
    pass
