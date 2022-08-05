def copy_by_list_method(array: list) -> list:
    """
    Array copy function using list method copy()

    :param array: array object
    :type array: list
    :return: copy of array
    :rtype: list
    """

    assert all(isinstance(x, type(array[0])) for x in array)  # имеют ли все элементы один тип

    return array.copy()


def copy_by_slice(array: list) -> list:
    """
    Array copy function using slicing

    :param array: array object
    :return: list
    """

    assert all(isinstance(x, type(array[0])) for x in array)  # имеют ли все элементы один тип

    return array[:]


def copy_by_comprehension(array: list) -> list:
    """
    Array copy function using list comprehension

    :param array:
    :return:
    """

    assert all(isinstance(x, type(array[0])) for x in array)  # имеют ли все элементы один тип

    return [el for el in array]


def copy_by_map(array: list) -> list:
    """
    Array copy function using map() function

    :param array:
    :return:
    """

    assert all(isinstance(x, type(array[0])) for x in array)  # имеют ли все элементы один тип

    return list(map(lambda x: x, array))


if __name__ == '__main__':
    pass
