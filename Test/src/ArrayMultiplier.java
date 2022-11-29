public class ArrayMultiplier {

    static int[] multiply(int[] arr1, int[] arr2) {
        if (arr1 == null || arr2 == null) {
            return null;
        }

        int resultLen = arr1.length + arr2.length - 1;
        int[] result = new int[resultLen];

        for (int i = 0; i < arr1.length; i++) {
            for (int j = 0; j < arr2.length; j++) {

                int index = i + j;
                int newInt = arr1[i] * arr2[j];
                result[index] += newInt;
            }
        }

        return result;
    }

}
