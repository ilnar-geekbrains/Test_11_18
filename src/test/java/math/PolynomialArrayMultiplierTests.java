package math;

import gb.math.PolynomialArrayMultiplier;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertArrayEquals;
import static org.junit.jupiter.api.Assertions.assertThrows;

public class PolynomialArrayMultiplierTests {
    PolynomialArrayMultiplier polynomialMultiplier = new PolynomialArrayMultiplier();

    @Test
    void multiply_test() {
        int[] arr1 = new int[]{-1,1};
        int[] arr2 = new int[]{2,1};
        int[] expectedResult = new int[]{-2,1,1};
        int[] actualResult = polynomialMultiplier.multiply(arr1, arr2);

        assertArrayEquals(expectedResult, actualResult);
    }

    @Test
    void multiply_when_one_array_is_null_test() {
        int[] arr1 = null;
        int[] arr2 = {1,2,3};
        assertThrows(IllegalArgumentException.class, () -> polynomialMultiplier.multiply(arr1, arr2));
    }

    @Test
    void multiply_when_one_array_is_empty_test() {
        int[] arr1 = {};
        int[] arr2 = {1,2,3};

        assertThrows(IllegalArgumentException.class, () -> polynomialMultiplier.multiply(arr1, arr2));
    }
}
