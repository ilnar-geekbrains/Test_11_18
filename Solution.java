class Solution {
    static int[] polynomMulti(int[] a, int[] b) {
        if (a.length == 0 || b.length == 0) {
            throw new RuntimeException("Данные не валидны");
        }

        int[] result = new int[a.length + b.length - 1];
        for (int i = 0; i < a.length; i++) {
            if (a[i] == 0) continue;
            for (int j = 0; j < b.length; j++) {
                result[i + j] += a[i] * b[j];
            }
        }
        return result;
    }

    static int[] copy(int[] srcArray) {
        if (srcArray.length == 0) return new int[] {};
        int[] result = new int[srcArray.length];
        for (int i = 0; i < srcArray.length; i++) {
            result[i] = srcArray[i];
        }
        return result;
    }
}
