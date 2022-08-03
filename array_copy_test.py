from typing import Callable

from array_copy import *


def test_method(func: Callable[[list], list]) -> None:
    test_cases = [
        [],
        [1],
        [{1: 32}, [123], "", 312],
        [
            {
                1: "",
                2: {
                    3: 4,
                    2: 4124
                }
            },
            "321",
            [56472, 89412345],
            (1, 3),
            {1, 2, 3},
        ],
    ]

    for test_case in test_cases:
        test_case_copy = func(test_case)
        assert test_case == test_case_copy
        assert test_case is not test_case_copy
        test_case.append("test_str")
        assert test_case != test_case_copy


if __name__ == "__main__":
    test_method(copy_array_simplest)
    test_method(copy_array_slice)
    test_method(copy_array_list_comprehension)
    test_method(copy_array_deeply)
