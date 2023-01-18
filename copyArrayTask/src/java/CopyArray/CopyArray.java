package CopyArray;

import Utils.UtilsCopyArray;

/**
 * Класс копирования массивов примитивных типов и Object с leftBoundInclude элемента по rightBoundExclude.
 */
public class CopyArray {

    /**
     * Метод копирования массивов Object[] с leftBoundInclude элемента по rightBoundExclude.
     * @param array
     * @param leftBoundInclude
     * @param rightBoundExclude
     * @return
     */
    public static Object[] copy(Object[] array, int leftBoundInclude, int rightBoundExclude) {
        UtilsCopyArray.validate(rightBoundExclude, leftBoundInclude, array.length);
        Object[] copyArray = new Object[rightBoundExclude - leftBoundInclude];
        System.arraycopy(array, leftBoundInclude, copyArray, 0, rightBoundExclude - leftBoundInclude);
        return copyArray;
    }

    /**
     * Метод копирования массивов int[] с leftBoundInclude элемента по rightBoundExclude.
     * @param array
     * @param leftBoundInclude
     * @param rightBoundExclude
     * @return
     */
    public static int[] copy(int[] array, int leftBoundInclude, int rightBoundExclude) {
        UtilsCopyArray.validate(rightBoundExclude, leftBoundInclude, array.length);
        int[] copyArray = new int[rightBoundExclude - leftBoundInclude];
        System.arraycopy(array, leftBoundInclude, copyArray, 0, rightBoundExclude - leftBoundInclude);
        return copyArray;
    }

    /**
     * Метод копирования массивов double[] с leftBoundInclude элемента по rightBoundExclude.
     * @param array
     * @param leftBoundInclude
     * @param rightBoundExclude
     * @return
     */
    public static double[] copy(double[] array, int leftBoundInclude, int rightBoundExclude) {
        UtilsCopyArray.validate(rightBoundExclude, leftBoundInclude, array.length);
        double[] copyArray = new double[rightBoundExclude - leftBoundInclude];
        System.arraycopy(array, leftBoundInclude, copyArray, 0, rightBoundExclude - leftBoundInclude);
        return copyArray;
    }

    /**
     * Метод копирования массивов float[] с leftBoundInclude элемента по rightBoundExclude.
     * @param array
     * @param leftBoundInclude
     * @param rightBoundExclude
     * @return
     */
    public static float[] copy(float[] array, int leftBoundInclude, int rightBoundExclude) {
        UtilsCopyArray.validate(rightBoundExclude, leftBoundInclude, array.length);
        float[] copyArray = new float[rightBoundExclude - leftBoundInclude];
        System.arraycopy(array, leftBoundInclude, copyArray, 0, rightBoundExclude - leftBoundInclude);
        return copyArray;
    }

    /**
     * Метод копирования массивов boolean[] с leftBoundInclude элемента по rightBoundExclude.
     * @param array
     * @param leftBoundInclude
     * @param rightBoundExclude
     * @return
     */
    public static boolean[] copy(boolean[] array, int leftBoundInclude, int rightBoundExclude) {
        UtilsCopyArray.validate(rightBoundExclude, leftBoundInclude, array.length);
        boolean[] copyArray = new boolean[rightBoundExclude - leftBoundInclude];
        System.arraycopy(array, leftBoundInclude, copyArray, 0, rightBoundExclude - leftBoundInclude);
        return copyArray;
    }

    /**
     * Метод копирования массивов byte[] с leftBoundInclude элемента по rightBoundExclude.
     * @param array
     * @param leftBoundInclude
     * @param rightBoundExclude
     * @return
     */
    public static byte[] copy(byte[] array, int leftBoundInclude, int rightBoundExclude) {
        UtilsCopyArray.validate(rightBoundExclude, leftBoundInclude, array.length);
        byte[] copyArray = new byte[rightBoundExclude - leftBoundInclude];
        System.arraycopy(array, leftBoundInclude, copyArray, 0, rightBoundExclude - leftBoundInclude);
        return copyArray;
    }

    /**
     * Метод копирования массивов short[] с leftBoundInclude элемента по rightBoundExclude.
     * @param array
     * @param leftBoundInclude
     * @param rightBoundExclude
     * @return
     */
    public static short[] copy(short[] array, int leftBoundInclude, int rightBoundExclude) {
        UtilsCopyArray.validate(rightBoundExclude, leftBoundInclude, array.length);
        short[] copyArray = new short[rightBoundExclude - leftBoundInclude];
        System.arraycopy(array, leftBoundInclude, copyArray, 0, rightBoundExclude - leftBoundInclude);
        return copyArray;
    }

    /**
     * Метод копирования массивов long[] с leftBoundInclude элемента по rightBoundExclude.
     * @param array
     * @param leftBoundInclude
     * @param rightBoundExclude
     * @return
     */
    public static long[] copy(long[] array, int leftBoundInclude, int rightBoundExclude) {
        UtilsCopyArray.validate(rightBoundExclude, leftBoundInclude, array.length);
        long[] copyArray = new long[rightBoundExclude - leftBoundInclude];
        System.arraycopy(array, leftBoundInclude, copyArray, 0, rightBoundExclude - leftBoundInclude);
        return copyArray;
    }

    /**
     * Метод копирования массивов char[] с leftBoundInclude элемента по rightBoundExclude.
     * @param array
     * @param leftBoundInclude
     * @param rightBoundExclude
     * @return
     */
    public static char[] copy(char[] array, int leftBoundInclude, int rightBoundExclude) {
        UtilsCopyArray.validate(rightBoundExclude, leftBoundInclude, array.length);
        char[] copyArray = new char[rightBoundExclude - leftBoundInclude];
        System.arraycopy(array, leftBoundInclude, copyArray, 0, rightBoundExclude - leftBoundInclude);
        return copyArray;
    }
}
