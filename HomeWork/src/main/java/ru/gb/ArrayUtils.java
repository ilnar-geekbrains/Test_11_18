package ru.gb;

import java.util.Arrays;

/**
 * This class contains various methods for copies arrays.
 *
 * @author Darakhvelidze A.A.
 * @since 1.6
 */
public class ArrayUtils {

    /**
     * Method copies the original array to the new one by cloning mechanism.
     *
     * @param array original array
     * @return new copied array, if objects array is null, method return null, if array is empty, method return empties
     * array
     */
    public static Object[] copyByCloning(Object[] array) {
        if (array == null) {
            return null;
        }
        if (array.length == 0) {
            return new Object[]{};
        }

        return array.clone();
    }

    /**
     * Method copies the original array to the new one by @see {@link java.util.Arrays} utils.
     *
     * @param array original array
     * @return new copied array, if objects array is null, method return null, if array is empty, method return empties
     * array
     */
    public static Object[] copyByArraysUtils(Object[] array) {
        if (array == null) {
            return null;
        }
        if (array.length == 0) {
            return new Object[]{};
        }

        return Arrays.copyOf(array, array.length);
    }

    /**
     * Method copies the original array to the new one by @see {@link System#arraycopy}.
     *
     * @param array original array
     * @return new copied array, if objects array is null, method return null, if array is empty, method return empties
     * array
     */
    public static Object[] copyBySystemCopy(Object[] array) {
        if (array == null) {
            return null;
        }
        if (array.length == 0) {
            return new Object[]{};
        }
        Object[] temp = new Object[array.length];
        System.arraycopy(array, 0, temp, 0, array.length);
        return temp;
    }

}
