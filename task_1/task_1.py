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