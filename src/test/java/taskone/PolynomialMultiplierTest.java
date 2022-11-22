package taskone;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.Arguments;
import org.junit.jupiter.params.provider.MethodSource;
import tasktwo.PolynomialMultiplier;

import java.util.stream.Stream;

import static org.junit.jupiter.api.Assertions.assertArrayEquals;
import static org.junit.jupiter.api.Assertions.assertThrows;

public class PolynomialMultiplierTest {

    PolynomialMultiplier polynomialMultiplier = new PolynomialMultiplier();

    @ParameterizedTest
    @MethodSource("provideArraysForMultiply")
    void testMultiply(int[] arr1, int[] arr2, int[] expectedResult) {
        var actualResult = polynomialMultiplier.multiply(arr1, arr2);

        assertArrayEquals(expectedResult, actualResult);
    }

    @Test
    void testMultiply_OneArrayIsNull_ThrowException() {
        int[] arr1 = null;
        int[] arr2 = {1,2,3};

        assertThrows(IllegalArgumentException.class, () -> polynomialMultiplier.multiply(arr1, arr2));
    }

    @Test
    void testMultiply_OneArrayIsEmpty_ThrowException() {
        int[] arr1 = {};
        int[] arr2 = {1,2,3};

        assertThrows(IllegalArgumentException.class, () -> polynomialMultiplier.multiply(arr1, arr2));
    }



    private static Stream<Arguments> provideArraysForMultiply() {
        return Stream.of(
                Arguments.of(new int[]{-1,1}, new int[]{2,1}, new int[]{-2,1,1}),
                Arguments.of(new int[]{1,0,3,2}, new int[]{2,0,4}, new int[]{2,0,10,4,12,8}),
                Arguments.of(new int[]{1,9,3,4,7}, new int[]{4,0,2,5}, new int[]{4,36,14,39,79,23,34,35})
        );
    }
}
