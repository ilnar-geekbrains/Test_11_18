package main.multiplyingArraysAsPolynomials;

import java.util.Arrays;

public class MultiplyingArraysAsPolynomials {
    public static double[] multiplyArrays(double[] array1, double[] array2) {
        if (array1.length == 0) return array2;
        if (array2.length == 0) return array1;
        double[] answer = new double[array1.length + array2.length - 1];
        for (int i = 0; i < array1.length; i++) {
            for (int t = 0; t < array2.length; t++) {
                answer[i + t] = answer[i + t] + array1[i] * array2[t];
            }
        }
        return answer;
    }

    public static void main(String[] args) {
        System.out.println(Arrays.toString(multiplyArrays(new double[]{1, 2, 3}, new double[]{1, 2})));
    }
}
