package ru.spb;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;

class SecondProblemTest {

    @Test
    @DisplayName("Passed arrays have same length and the result is OK")
    void test() {
        var actualArray = SecondProblem.multiplyArrays(new int[]{-1, 1}, new int[]{2, 1});
        var expectedArray = new int[]{-2, 1, 1};

        Assertions.assertArrayEquals(expectedArray, actualArray);
    }

    @Test
    @DisplayName("Passed arrays have different length and the result is OK")
    void test1() {
        var actualArray = SecondProblem.multiplyArrays(new int[]{-1, 1, 3}, new int[]{2});
        var expectedArray = new int[]{-2, 2, 6};

        Assertions.assertArrayEquals(expectedArray, actualArray);
    }

    @Test
    @DisplayName("Second array is empty -> throw an exception")
    void test2() {
        Assertions.assertThrows(RuntimeException.class,
                () -> SecondProblem.multiplyArrays(new int[]{-1, 1}, new int[]{}));
    }

    @Test
    @DisplayName("First array is empty -> throw an exception")
    void test3() {
        Assertions.assertThrows(RuntimeException.class,
                () -> SecondProblem.multiplyArrays(new int[]{}, new int[]{1, 1}));
    }

    @Test
    @DisplayName("One of the arrays is null -> throw an exception")
    void test4() {
        Assertions.assertThrows(RuntimeException.class,
                () -> SecondProblem.multiplyArrays(null, new int[]{1, 1}));
    }

    @Test
    @DisplayName("Both arrays have length 1")
    void test5() {
        var actualArray = SecondProblem.multiplyArrays(new int[]{3}, new int[]{2});
        var expectedArray = new int[]{-2, 2};

        Assertions.assertArrayEquals(expectedArray, actualArray);
    }

    @Test
    @DisplayName("All items are 0")
    void test6() {
        var actualArray = SecondProblem.multiplyArrays(new int[]{0, 0, 0}, new int[]{0, 0});
        var expectedArray = new int[]{0, 0, 0};

        Assertions.assertArrayEquals(expectedArray, actualArray);
    }

    @Test
    @DisplayName("One polynom has only one coeff 0")
    void test7() {
        var actualArray = SecondProblem.multiplyArrays(new int[]{1, 2, 3}, new int[]{0});
        var expectedArray = new int[]{0, 0, 0};

        Assertions.assertArrayEquals(expectedArray, actualArray);
    }
}