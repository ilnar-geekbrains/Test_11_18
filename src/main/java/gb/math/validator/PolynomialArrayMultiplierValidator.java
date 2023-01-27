package gb.math.validator;

public interface PolynomialArrayMultiplierValidator {
    default boolean isValid(int[] arr1, int[] arr2) {
        if (arr1 == null || arr2 == null) {
            throw new IllegalArgumentException("One of arrays is null");
        }

        if (arr1.length == 0 || arr2.length == 0) {
            throw new IllegalArgumentException("One of arrays is empty");
        }
        return true;
    }
}
