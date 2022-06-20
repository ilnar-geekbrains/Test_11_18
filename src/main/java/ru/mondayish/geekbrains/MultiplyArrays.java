package ru.mondayish.geekbrains;

public class MultiplyArrays {

    public double[] multiply(double[] array1, double[] array2) {
        int totalLength = array1.length + array2.length - 1;
        double[] result = new double[totalLength];
        for (int i = 0; i < array1.length; i++) {
            for (int j = 0; j < array2.length; j++) {
                result[i + j] += array1[i] * array2[j];
            }
        }
        return result;
    }
}
