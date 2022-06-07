package ru.geekbrains;

public class PolynomialProduction {

    public static int[] multiply(int[] p1, int[] p2) {
        if (p1 == null) {
            throw new IllegalArgumentException("First polynomial is null");
        }
        if (p2 == null) {
            throw new IllegalArgumentException("Second polynomial is null");
        }
        int[] res = new int[p1.length + p2.length - 1];
        for (int i=0; i < p1.length; i++) {
            for (int j=0; j < p2.length; j++) {
                res[i+j] += p1[i] * p2[j];
            }
        }
        return res;
    }
}
