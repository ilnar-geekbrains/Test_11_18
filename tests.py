import unittest

from solution import Polynom


class TestPolynomSolytion(unittest.TestCase):

    # подготавливаем данные, где произведение 1 полинома на 2 полином равно 3 полиному
    polynoms_preset = (
        ([-1, 1], [2, 1], [-2, 1, 1]),
        ([-2, 1], [3, 1], [-6, 1, 1]),
        ([-4, 3], [-3, 15], [12, -69, 45]),
    )

    # подготавливаем данные, где произведение 1 полинома на 2 полином НЕ равно 3 полиному
    polynoms_preset_not_equal = (
        ([-1, 1], [2, 1], [-2, 1, 2]),
        ([-2, 1], [3, 1], [-6, 1, 2]),
        ([-4, 3], [-3, 15], [12, -69, 46]),
    )

    # подготавливаем данные с полиномами и их длинами
    polynoms_length = (
        ([1, ], 1),
        ([1, 2, ], 2),
        ([1, 2, 3, ], 3),
        ([1, 2, 3, 4, ], 4),
        ([1, 2, 3, 4, 5, ], 5),
    )

    # подготавливаем данные с полиномами
    polynoms = (
        [1, ],
        [1, 2, ],
        [1, 2, 3, ],
        [1, 2, 3, 4, ],
        [1, 2, 3, 4, 5, ],
    )

    def test_multiply_polynoms_equal(self) -> None:
        for polynoms in self.polynoms_preset:
            self.assertEqual(
                Polynom(polynoms[0]) * Polynom(polynoms[1]),
                Polynom(polynoms[2]),
            )

    def test_multiply_polynoms_not_equal(self) -> None:
        for polynoms in self.polynoms_preset_not_equal:
            self.assertNotEqual(
                Polynom(polynoms[0]) * Polynom(polynoms[1]),
                Polynom(polynoms[2]),
            )

    def test_polynom_length(self) -> None:
        for polynom, length in self.polynoms_length:
            self.assertEqual(len(polynom), length)

    def test_polynom_repr(self) -> None:
        for polynom in self.polynoms:
            self.assertEqual(
                (Polynom(polynom)).__repr__(),
                str(polynom),
            )


if __name__ == '__main__':
    unittest.main()
