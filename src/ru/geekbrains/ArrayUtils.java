package ru.geekbrains;

import java.lang.reflect.Array;
import java.util.Arrays;

import static java.util.Objects.isNull;

/**
 * Assessment #1. Write a program to copy an array.
 * <p>
 * There are not enough conditions in the statement, e.g.:
 * 1) Which types of array elements should be supported - primitives (wrappers) or ref-types?
 * 2) Which type of copying should be implemented - shallow or deep?
 * <p>
 * For ease of implementation, we assume that array elements can only be primitives, which means that shallow copying is enough.
 */
public class ArrayUtils {

    private static final String SRC_ARRAY_MUST_NOT_BE_NULL = "parameter 'srcArray' must not be null";

    /**
     * Copy array with Arrays.copyOf implementation.
     */
    public static <T> T[] copyArray1(T[] srcArray) {
        if (isNull(srcArray)) {
            throw new IllegalArgumentException(SRC_ARRAY_MUST_NOT_BE_NULL);
        }
        return Arrays.copyOf(srcArray, srcArray.length);
    }

    /**
     * Copy array with System.arraycopy implementation.
     */
    public static <T> T[] copyArray2(T[] srcArray) {
        if (isNull(srcArray)) {
            throw new IllegalArgumentException(SRC_ARRAY_MUST_NOT_BE_NULL);
        }
        T[] arrayCopy = newArrayInstance(srcArray);
        System.arraycopy(srcArray, 0, arrayCopy, 0, srcArray.length);
        return arrayCopy;
    }

    /**
     * Copy array with shallow copy clone implementation.
     */
    public static <T> T[] copyArray3(T[] srcArray) {
        if (isNull(srcArray)) {
            throw new IllegalArgumentException(SRC_ARRAY_MUST_NOT_BE_NULL);
        }
        try {
            return srcArray.clone();
        } catch (Exception e) {
            throw new IllegalArgumentException(e.getCause());
        }
    }

    /**
     * Copy array with manual copying.
     */
    public static <T> T[] copyArray4(T[] srcArray) {
        if (isNull(srcArray)) {
            throw new IllegalArgumentException(SRC_ARRAY_MUST_NOT_BE_NULL);
        }
        if (srcArray.length == 0) {
            return newArrayInstance(srcArray);
        }
        var arrayCopy = newArrayInstance(srcArray);
        for (int i = 0; i < srcArray.length; i++) {
            arrayCopy[i] = srcArray[i];
        }
        return arrayCopy;
    }

    @SuppressWarnings("unchecked")
    private static <T> T[] newArrayInstance(T[] srcArray) {
        return (T[]) Array.newInstance(srcArray.getClass().getComponentType(), srcArray.length);
    }
}
