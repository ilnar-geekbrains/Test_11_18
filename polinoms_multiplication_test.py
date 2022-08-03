from polinoms_multiplication import multiply_polinoms_simple


def test_polinoms_multiplication():
    test_cases = [
        [[-7, 1], [1, 4], [-7, -27, 4]],
        [[-1, 1], [2, 1], [-2, 1, 1]],
        [[234, 32], [435, 32], [101790, 21408, 1024]],
        [[0, 0], [0, 0], [0, 0, 0]]
    ]
    for test_case in test_cases:
        assert multiply_polinoms_simple(test_case[0], test_case[1]) == test_case[2]

if __name__ == "__main__":
    test_polinoms_multiplication()
