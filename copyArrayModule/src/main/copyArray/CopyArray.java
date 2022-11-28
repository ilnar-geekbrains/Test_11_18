package main.copyArray;

public class CopyArray {

    public static int[] copy(int[] array, int leftBoundInclude, int rightBoundExclude) {
        validate(rightBoundExclude, leftBoundInclude, array.length);
        int[] copy = new int[rightBoundExclude - leftBoundInclude];
        for (int i = leftBoundInclude; i < rightBoundExclude; i++) copy[i - leftBoundInclude] = array[i];
        return copy;
    }

    public static double[] copy(double[] array, int leftBoundInclude, int rightBoundExclude) {
        validate(rightBoundExclude, leftBoundInclude, array.length);
        double[] copy = new double[rightBoundExclude - leftBoundInclude];
        if (rightBoundExclude - leftBoundInclude >= 0)
            System.arraycopy(array, leftBoundInclude, copy, 0, rightBoundExclude - leftBoundInclude);
        return copy;
    }

    public static float[] copy(float[] array, int leftBoundInclude, int rightBoundExclude) {
        validate(rightBoundExclude, leftBoundInclude, array.length);
        float[] copy = new float[rightBoundExclude - leftBoundInclude];
        if (rightBoundExclude - leftBoundInclude >= 0)
            System.arraycopy(array, leftBoundInclude, copy, 0, rightBoundExclude - leftBoundInclude);
        return copy;
    }

    public static boolean[] copy(boolean[] array, int leftBoundInclude, int rightBoundExclude) {
        validate(rightBoundExclude, leftBoundInclude, array.length);
        boolean[] copy = new boolean[rightBoundExclude - leftBoundInclude];
        if (rightBoundExclude - leftBoundInclude >= 0)
            System.arraycopy(array, leftBoundInclude, copy, 0, rightBoundExclude - leftBoundInclude);
        return copy;
    }

    public static byte[] copy(byte[] array, int leftBoundInclude, int rightBoundExclude) {
        validate(rightBoundExclude, leftBoundInclude, array.length);
        byte[] copy = new byte[rightBoundExclude - leftBoundInclude];
        if (rightBoundExclude - leftBoundInclude >= 0)
            System.arraycopy(array, leftBoundInclude, copy, 0, rightBoundExclude - leftBoundInclude);
        return copy;
    }

    public static short[] copy(short[] array, int leftBoundInclude, int rightBoundExclude) {
        validate(rightBoundExclude, leftBoundInclude, array.length);
        short[] copy = new short[rightBoundExclude - leftBoundInclude];
        if (rightBoundExclude - leftBoundInclude >= 0)
            System.arraycopy(array, leftBoundInclude, copy, 0, rightBoundExclude - leftBoundInclude);
        return copy;
    }

    public static long[] copy(long[] array, int leftBoundInclude, int rightBoundExclude) {
        validate(rightBoundExclude, leftBoundInclude, array.length);
        long[] copy = new long[rightBoundExclude - leftBoundInclude];
        if (rightBoundExclude - leftBoundInclude >= 0)
            System.arraycopy(array, leftBoundInclude, copy, 0, rightBoundExclude - leftBoundInclude);
        return copy;
    }

    public static char[] copy(char[] array, int leftBoundInclude, int rightBoundExclude) {
        validate(rightBoundExclude, leftBoundInclude, array.length);
        char[] copy = new char[rightBoundExclude - leftBoundInclude];
        if (rightBoundExclude - leftBoundInclude >= 0)
            System.arraycopy(array, leftBoundInclude, copy, 0, rightBoundExclude - leftBoundInclude);
        return copy;
    }

    public static Object[] copy(Object[] array, int leftBoundInclude, int rightBoundExclude) {
        validate(rightBoundExclude, leftBoundInclude, array.length);
        Object[] copy = new Object[rightBoundExclude - leftBoundInclude];
        if (rightBoundExclude - leftBoundInclude >= 0)
            System.arraycopy(array, leftBoundInclude, copy, 0, rightBoundExclude - leftBoundInclude);
        return copy;
    }

    private static void validate(int rightBound, int leftBound, int arrayLength) {
        if (rightBound < 0 || leftBound < 0)
            throw new IllegalArgumentException("Границы копирования массива не могу иметь отрицательные значения");
        if (rightBound < leftBound)
            throw new IllegalArgumentException("Правая граница копирования массива не может быть меньше левой");
        if (arrayLength < rightBound){
            throw new IllegalArgumentException("Границы копирования массива не могут превышать размер массива");
        }
    }
}
