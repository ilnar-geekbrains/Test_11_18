from collections.abc import Iterable


# easy solutions
def copy_array_simplest(array: list) -> list:
    """copies through simple enumeration"""

    new_array = []
    for item in array:
        new_array.append(item)
    return new_array


def copy_array_slice(array: list) -> list:
    """copies array with slicing"""

    return array[:]


def copy_array_list_comprehension(array: list) -> list:
    """copies array with list_comprehension"""

    return [item for item in array]


# decent solution
def copy_array_deeply(array: list) -> list:
    """copies array structure recursively for the iterible items"""

    # checking if the argument's type is list
    if not isinstance(array, list):  # if that's too hard may use type(array) == list
        raise TypeError
    new_array = []
    for item in array:
        item = copy_recursively(item)  # to ease that could just use one level of nesting without recursion
        new_array.append(item)
    return new_array


def copy_recursively(possible_iterable):
    if not isinstance(possible_iterable, Iterable):
        return possible_iterable

    new_iterable = type(possible_iterable).__new__(type(possible_iterable))
    # there is a bit of hardcoding, but abstractioning would take a bunch of time
    if isinstance(new_iterable, dict):
        for key, value in possible_iterable.items():
            new_iterable[key] = copy_recursively(value)
    elif isinstance(new_iterable, list):
        for item in possible_iterable:
            new_iterable.append(copy_recursively(item))
    elif isinstance(new_iterable, set):
        for item in possible_iterable:
            new_iterable.add(copy_recursively(item))
    else:
        # tuples and frozensets don't need to be copied
        new_iterable = possible_iterable
    return new_iterable
