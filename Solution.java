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
    
    public static void main(String[] args) {
        int[] a = new int[]{-1, 1};
        int[] b = new int[]{2, 1};
        int[] result = polynomMulti(a, b);
        if (result[0] == -2 && result[1] == 1 && result[2] == 1) {
            System.out.println("Тест 1 пройден");
        } else {
            System.out.println("Тест 1 не пройден");
        }

        int[] source1 = new int[]{};
        int[] source2 = new int[]{1};
        int[] result1 = copy(source1);
        int[] result2 = copy(source2);

        if (result1 != source1 && result1.length == 0) {
            System.out.println("Тест 2 пройден");
        } else {
            System.out.println("Тест 2 не пройден");
        }

        if (result2 != source2 && result2[0] == source2[0]) {
            System.out.println("Тест 3 пройден");
        } else {
            System.out.println("Тест 3 не пройден");
        }


    }
}
