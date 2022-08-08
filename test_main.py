import pytest

from main import copy_list, multiply_polynomial


@pytest.mark.parametrize(
    'array,expected',
    (
            ([[3, 7], [5, 4]], [[3, 7], [5, 4]]),
            ([], []),
            ('qwerty', "xcasdasd")
    ),
)
def test_copy_list(array: list, expected: list):
    assert copy_array(array) == expected


def test_multiply_polynomial():
    assert 'Неверный формат данных' in multiply_arrays('qwerty', {'12':'test'})
    assert multiply_arrays([-1, 1], [2, 1]) == [-2, 1, 1]