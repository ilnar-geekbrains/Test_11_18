from unittest import TestCase, main
from task_2 import main_func


class TestArrayMultiplication(TestCase):

    def test_for_two_arrays(self):
        arrays = (
            [-1, 1],
            [2, 1],
        )
        expected = [-2, 1, 1]
        self.assertEqual(main_func(*arrays), expected)


if __name__ == '__main__':
    main()
