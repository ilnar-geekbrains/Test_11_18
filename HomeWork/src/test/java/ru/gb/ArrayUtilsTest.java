package ru.gb;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class ArrayUtilsTest {

    @Test
    void copyByCloningTestOnNull() {
        assertNull(ArrayUtils.copyByCloning(null));
    }

    @Test
    void copyByCloningTestOnEmptyArray() {
        assertArrayEquals(ArrayUtils.copyByCloning(new Integer[]{}), new Integer[]{});
    }

    @Test
    void copyByCloningTestSuccess() {
        assertArrayEquals(ArrayUtils.copyByCloning(new Integer[]{1, 2, 3}), new Integer[]{1, 2, 3});
    }

    @Test
    void copyByArraysUtilsOnNull() {
        assertNull(ArrayUtils.copyByArraysUtils(null));
    }

    @Test
    void copyByArraysUtilsOnEmptyArray() {
        assertArrayEquals(ArrayUtils.copyByArraysUtils(new Integer[]{}), new Integer[]{});
    }

    @Test
    void copyByArraysUtilsSuccess() {
        assertArrayEquals(ArrayUtils.copyByArraysUtils(new Integer[]{1, 2, 3}), new Integer[]{1, 2, 3});
    }

    @Test
    void copyBySystemCopyOnNull() {
        assertNull(ArrayUtils.copyBySystemCopy(null));
    }

    @Test
    void copyBySystemCopyOnEmptyArray() {
        assertArrayEquals(ArrayUtils.copyBySystemCopy(new Integer[]{}), new Integer[]{});
    }

    @Test
    void copyBySystemCopySuccess() {
        assertArrayEquals(ArrayUtils.copyBySystemCopy(new Integer[]{1, 2, 3}), new Integer[]{1, 2, 3});
    }
}