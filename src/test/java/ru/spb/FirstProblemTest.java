package ru.spb;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;

class FirstProblemTest {

    @Test
    @DisplayName("copy Integer Array - OK")
    void test1() {
        var actualArray = (Integer[]) FirstProblem.copyArray(new Integer[]{1, 2, 3});
        var expectedArray = new Integer[]{1, 2, 3};

        Assertions.assertArrayEquals(expectedArray, actualArray);
    }

    @Test
    @DisplayName("copy Double Array - OK")
    void test2() {
        var actualArray = (Double[]) FirstProblem.copyArray(new Double[]{1.0, 2.0, 3.0});
        var expectedArray = new Double[]{1.0, 2.0, 3.0};

        Assertions.assertArrayEquals(expectedArray, actualArray);
    }

    @Test
    @DisplayName("copy String Array - OK")
    void test3() {
        var actualArray = (String[]) FirstProblem.copyArray(new String[]{"1", "2", "3"});
        var expectedArray = new String[]{"1", "2", "3"};

        Assertions.assertArrayEquals(expectedArray, actualArray);
    }

    @Test
    @DisplayName("Passed array is empty -> throw exception")
    void test4() {
        Assertions.assertThrows(RuntimeException.class, () -> FirstProblem.copyArray(new Object[]{}));
    }

    @Test
    @DisplayName("Passed array is null -> throw exception")
    void test5() {
        Assertions.assertThrows(RuntimeException.class, () -> FirstProblem.copyArray(null));
    }
}