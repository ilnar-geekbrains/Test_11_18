package ru.geekbrains;

import java.util.Arrays;

import static java.lang.String.format;
import static java.util.Arrays.deepToString;

public class Asserts {

    public static final String ERROR_MESSAGE_TEMPLATE = """
            Assertion failed for
            > array1: (%s)
            > array2: (%s)
            Cause: %s""";

    static <T> void assertNotTheSame(T[] array1, T[] array2) {
        if (array1 == array2) {
            throw new AssertionError(
                    format(ERROR_MESSAGE_TEMPLATE, deepToString(array1), deepToString(array2),
                            "Arrays must not be the same object")
            );
        }
    }

    static <T> void assertEquals(T[] array1, T[] array2) {
        boolean equals = Arrays.equals(array1, array2);
        if (!equals) {
            throw new AssertionError(
                    format(ERROR_MESSAGE_TEMPLATE, deepToString(array1), deepToString(array2),
                            "Arrays should be equivalent")
            );
        }
    }
}
