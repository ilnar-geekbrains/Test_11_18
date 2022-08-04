import pytest

from main import copy_array, multiply_arrays


@pytest.mark.parametrize(
    'array,expected',
    (
            ([[1, 2], [3, 4]], [[1, 2], [3, 4]]),
            ([], []),
            ('строка', "Неверный формат данных")
    ),
)
def test_copy_array(array: list, expected: list):
    assert copy_array(array) == expected


def test_multiply_arrays():
    assert multiply_arrays([-1, 1], [2, 1]) == [-2, 1, 1]
    assert multiply_arrays([2, 3, 0, 1], [1, 1]) == [2, 5, 3, 1, 1]
    assert 'Неверный формат данных' in multiply_arrays(115, 12)
