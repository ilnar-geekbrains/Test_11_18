package tasktwo;

public class PolynomialMultiplier {

    public int[] multiply(int[] arr1, int[] arr2) {
        validate(arr1, arr2);

        int[] result = new int[arr1.length + arr2.length - 1];

        for (int i = 0; i < arr1.length; i++) {
            for (int j = 0; j < arr2.length; j++) {
                result[i+j] = result[i+j] + arr1[i]*arr2[j];
            }
        }
        return result;
    }

    private void validate(int[] arr1, int[] arr2) {
        if (arr1 == null || arr2 == null) {
            throw new IllegalArgumentException("One of arrays is null");
        }

        if (arr1.length == 0 || arr2.length == 0) {
            throw new IllegalArgumentException("One of arrays is empty");
        }
    }
}
