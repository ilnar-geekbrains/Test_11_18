package ru.spb;

public class SecondProblem {

    public static int[] multiplyArrays(int[] firstArray, int[] secondArray) {
        if (firstArray == null || secondArray == null) {
            throw new RuntimeException("One of passed arrays is null");
        }
        if (firstArray.length == 0 || secondArray.length == 0) {
            throw new RuntimeException("One of passed arrays is empty");
        }

        var result = new int[firstArray.length + secondArray.length - 1];
        for (int i = 0; i < firstArray.length; i++) {
            for (int j = 0; j < secondArray.length; j++) {
                result[i + j] += firstArray[i] * secondArray[j];
            }
        }

        return result;
    }
}
