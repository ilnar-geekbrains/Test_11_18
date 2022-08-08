import pytest

from main import copy_array, multiply_polinomials


@pytest.mark.parametrize(
     "array,expected",
     (
             ([], []),
             ([1, 2, 3], [1, 2, 3])
     ),
 )
def test_copy_array(array: list, expected: list):
     assert copy_array(array) == expected

def test_multiply_polinomials_ok():
        assert multiply_polinomials([1,5,2], [6,1,4,3]) == [6,31,21,25,23,6]


@pytest.mark.parametrize(
        "array",
        (
                [0.2],
                ['test'],
        
        ),
)
def test_multiply_polinomials_error(array: list):
        with pytest.raises(ValueError, match="Invalid polinomial"):
                multiply_polinomials(array, [1])
