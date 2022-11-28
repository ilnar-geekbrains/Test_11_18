package main.test;

import main.multiplyingArraysAsPolynomials.MultiplyingArraysAsPolynomials;

public final class TestMultiplyingArraysAsPolynomials {

    public static boolean whenEachArrayHasZeroLength() {
        try {
            return MultiplyingArraysAsPolynomials.multiplyArrays(new double[]{}, new double[]{}).length == 0;
        } catch (Exception e) {
            return false;
        }
    }

    public static boolean whenOneArrayHasZeroLength() {
        try {
            double[] rightAnswer = new double[]{1, 2};
            double[] answer = MultiplyingArraysAsPolynomials.multiplyArrays(rightAnswer, new double[]{});
            if (rightAnswer.length != answer.length) return false;
            for (int i = 0; i < rightAnswer.length; i++) if (rightAnswer[i] != answer[i]) return false;
            return true;
        } catch (Exception e) {
            return false;
        }
    }

    public static boolean whenEachArrayHasSingleElement() {
        try {
            double[] rightAnswer = new double[]{4};
            double[] answer = MultiplyingArraysAsPolynomials.multiplyArrays(new double[]{2}, new double[]{2});
            if (rightAnswer.length != answer.length) return false;
            for (int i = 0; i < rightAnswer.length; i++) if (rightAnswer[i] != answer[i]) return false;
            return true;
        } catch (Exception e) {
            return false;
        }
    }

    public static boolean whenEachArrayHasOnlyNegativeElements() {
        try {
            double[] rightAnswer = new double[]{1, 4, 4};
            double[] answer = MultiplyingArraysAsPolynomials.multiplyArrays(new double[]{-1, -2}, new double[]{-1, -2});
            if (rightAnswer.length != answer.length) return false;
            for (int i = 0; i < rightAnswer.length; i++) if (rightAnswer[i] != answer[i]) return false;
            return true;
        } catch (Exception e) {
            return false;
        }
    }

    public static boolean whenDataCorrect() {
        try {
            double[] rightAnswer = new double[]{1, 4, 10, 12, 9};
            double[] answer = MultiplyingArraysAsPolynomials.multiplyArrays(new double[]{1, 2, 3}, new double[]{1, 2, 3});
            if (rightAnswer.length != answer.length) return false;
            for (int i = 0; i < rightAnswer.length; i++) if (rightAnswer[i] != answer[i]) return false;
            return true;
        } catch (Exception e) {
            return false;
        }
    }

    public static void main(String[] args) {
        System.out.println("Test multiplying arrays as polynomials");
        System.out.println("whenEachArrayHasZeroLength: " + whenEachArrayHasZeroLength());
        System.out.println("whenOneArrayHasZeroLength: " + whenOneArrayHasZeroLength());
        System.out.println("whenEachArrayHasSingleElement: " + whenEachArrayHasSingleElement());
        System.out.println("whenEachArrayHasOnlyNegativeElements: " + whenEachArrayHasOnlyNegativeElements());
        System.out.println("whenDataCorrect: " + whenDataCorrect());
    }
}
