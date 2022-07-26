package ru.dap.array;

import java.util.stream.Stream;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.Arguments;
import org.junit.jupiter.params.provider.MethodSource;

/**
 * @author dapodshivalov
 */
class IntegerArrayProductOperationTest {

    private final IntegerArrayProductOperation product = new IntegerArrayProductOperation();

    @ParameterizedTest
    @MethodSource
    void testProduct(int[] left, int[] right, int[] expected) {
        int[] actual = product.apply(left, right);
        if (expected == null) {
            Assertions.assertNull(actual);
        }
        Assertions.assertEquals(expected.length, actual.length);

        for (int i = 0; i < expected.length; i++) {

            Assertions.assertEquals(
                expected[i],
                actual[i],
                String.format("%d != %d at position %d", expected[i], actual[i], i)
            );
        }
    }

    private static Stream<Arguments> testProduct() {
        return Stream.of(
            Arguments.of(new int[] {1, 2, 3}, new int[] {4, 5, 6}, new int[] {4, 13, 28, 27, 18}),
            Arguments.of(new int[] {2, 3}, new int[] {4, 5, 6}, new int[] {8, 22, 27, 18}),
            Arguments.of(new int[] {3}, new int[] {4, 0}, new int[] {12, 0}),
            Arguments.of(new int[] {3}, new int[] {-6}, new int[] {-18})
        );
    }

    @Test
    void productShouldFailByEmptyArray() {
        Assertions.assertThrows(IllegalArgumentException.class, () -> product.apply(new int[] {}, new int[] {1, 2, 3}));
    }

    @Test
    void productShouldFailByNullArray() {
        Assertions.assertThrows(NullPointerException.class, () -> product.apply(null, new int[] {1, 2, 3}));
    }
}