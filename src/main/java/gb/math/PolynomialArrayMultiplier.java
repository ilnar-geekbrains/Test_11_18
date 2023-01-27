package gb.math;

import gb.math.validator.PolynomialArrayMultiplierValidator;

public class PolynomialArrayMultiplier implements PolynomialArrayMultiplierValidator {
    public int[] multiply(int[] arr1, int[] arr2) {
        if (isValid(arr1, arr2)) {
            int[] result = new int[arr1.length + arr2.length - 1];

            for (int i = 0; i < arr1.length; i++) {
                for (int j = 0; j < arr2.length; j++) {
                    result[i+j] = result[i+j] + arr1[i]*arr2[j];
                }
            }
            return result;
        } else {
            throw new IllegalArgumentException("One of the arrays failed validation");
        }
    }
}
