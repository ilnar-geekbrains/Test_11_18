import unittest

from result import mul_arrays


class TestArrayMultiplication(unittest.TestCase):

    def test_1(self):
        expected_result = [-2.0, 1.0, 1.0]
        array_1 = [-1, 1]
        array_2 = [2, 1]
        result = mul_arrays(array_1, array_2)
        self.assertEqual(expected_result, result)

    def test_2(self):
        expected_result = [-5.0, -3.0, 3.0, -4.0, 2.0, 1.0]
        array_1 = [-5, 2, 1]
        array_2 = [1, 1, 0, 1]
        result = mul_arrays(array_1, array_2)
        self.assertEqual(expected_result, result)

    def test_type_error(self):
        array_1 = (-5, 2, 1)
        array_2 = [1, 1, 0, 1]
        with self.assertRaises(TypeError):
            mul_arrays(array_1, array_2)
