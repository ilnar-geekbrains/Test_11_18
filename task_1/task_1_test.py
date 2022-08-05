from unittest import TestCase, main
from task_1 import *


class TestArrayCopy(TestCase):

    def test_length(self):
        array = [-1, 1]
        expected = 2
        self.assertTrue(len(copy_by_list_method(array)), expected)
        self.assertTrue(len(copy_by_slice(array)), expected)
        self.assertTrue(len(copy_by_comprehension(array)), expected)
        self.assertTrue(len(copy_by_map(array)), expected)

    def test_simple(self):
        array = [-1, 1]
        expected = [-1, 1]
        self.assertEqual(copy_by_list_method(array), expected)
        self.assertEqual(copy_by_slice(array), expected)
        self.assertEqual(copy_by_comprehension(array), expected)
        self.assertEqual(copy_by_map(array), expected)


if __name__ == '__main__':
    main()
