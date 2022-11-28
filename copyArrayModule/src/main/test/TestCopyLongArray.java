package main.test;

import main.copyArray.CopyArray;

public final class TestCopyLongArray {

    private static final String whenRightBoundLessThanLeftExceptionText = "Правая граница копирования массива не может быть меньше левой";
    private static final String whenRightBoundAndLeftIsNegativeExceptionText = "Границы копирования массива не могу иметь отрицательные значения";
    private static final String whenArrayLengthLessThanBoundsText = "Границы копирования массива не могут превышать размер массива";

    public static boolean whenArrayIsEmpty() {
        try {
            return CopyArray.copy(new long[]{}, 0, 0).length == 0;
        } catch (Exception e) {
            return false;
        }
    }

    public static boolean whenRightBoundLessThanLeft() {
        try {
            CopyArray.copy(new long[]{1, 2}, 2, 1);
        } catch (IllegalArgumentException e) {
            return e.getMessage().equals(whenRightBoundLessThanLeftExceptionText);
        } catch (Exception e) {
            return false;
        }
        return false;
    }

    public static boolean whenRightBoundEqualLeft() {
        try {
            return CopyArray.copy(new long[]{1, 2}, 1, 1).length == 0;
        } catch (Exception e) {
            return false;
        }
    }

    public static boolean whenRightBoundAndLeftIsZero() {
        try {
            return CopyArray.copy(new long[]{1, 2}, 0, 0).length == 0;
        } catch (Exception e) {
            return false;
        }
    }

    public static boolean whenRightBoundAndLeftIsNegative() {
        try {
            CopyArray.copy(new long[]{1, 2}, -1, -5);
        } catch (IllegalArgumentException e) {
            return e.getMessage().equals(whenRightBoundAndLeftIsNegativeExceptionText);
        } catch (Exception e) {
            return false;
        }
        return false;
    }

    public static boolean whenArrayLengthLessThanBounds() {
        try {
            CopyArray.copy(new long[]{1, 2}, 1, 5);
        } catch (IllegalArgumentException e) {
            return e.getMessage().equals(whenArrayLengthLessThanBoundsText);
        } catch (Exception e) {
            return false;
        }
        return false;
    }

    public static boolean whenDataCorrect() {
        try {
            long[] rightAnswer = new long[]{2, 3, 4};
            long[] answer = CopyArray.copy(new long[]{1, 2, 3, 4, 5}, 1, 4);
            if (rightAnswer.length != answer.length) return false;
            for (int i = 0; i < rightAnswer.length; i++) if (rightAnswer[i] != answer[i]) return false;
            return true;
        } catch (Exception e) {
            return false;
        }
    }

    public static void main(String[] args) {
        System.out.println("Starting copy longs array tests");
        System.out.println("whenArrayIsEmpty: " + whenArrayIsEmpty());
        System.out.println("whenRightBoundLessThanLeft: " + whenRightBoundLessThanLeft());
        System.out.println("whenRightBoundEqualLeft: " + whenRightBoundEqualLeft());
        System.out.println("whenRightBoundAndLeftIsZero: " + whenRightBoundAndLeftIsZero());
        System.out.println("whenRightBoundAndLeftIsNegative: " + whenRightBoundAndLeftIsNegative());
        System.out.println("whenRightBoundAndLeftIsNegative: " + whenRightBoundEqualLeft());
        System.out.println("whenDataCorrect: " + whenDataCorrect());
    }
}
