package CopyArray;

import org.junit.Assert;

/**
 * Набор простеньких тестов.
 * Все ситуации тестить не стал, в данной задаче, на мой взгляд, достаточно.
 */
public class CopyArrayTest {
    private final int[] testArray = {1, 2, 3, 4, 5, 6, 7, 8, 9};
    private final long[] testArrayLong = {1, 2, 3, 4, 5, 6, 7, 8, 9};
    private final boolean[] testArrayBoolean = {true, false, false, true, false, false};

    @org.junit.Test
    public void copy() {
        int[] expectedArray = {2, 3, 4};
        Assert.assertArrayEquals(expectedArray, CopyArray.copy(testArray, 1, 4));
    }

    @org.junit.Test
    public void copyLongArray() {
        long[] expectedArray = {2, 3, 4};
        Assert.assertArrayEquals(expectedArray, CopyArray.copy(testArrayLong, 1, 4));
    }

    @org.junit.Test
    public void copyLongBoolean() {
        boolean[] expectedArray = {true, false, false};
        Assert.assertArrayEquals(expectedArray, CopyArray.copy(testArrayBoolean, 3, 6));
    }

    @org.junit.Test(expected = IllegalArgumentException.class)
    public void testCopyException() throws IllegalArgumentException {
        CopyArray.copy(testArray, -1, 4);
    }

    @org.junit.Test(expected = IllegalArgumentException.class)
    public void testCopyException1() throws IllegalArgumentException {
        CopyArray.copy(testArray, 4, 3);
    }

    @org.junit.Test(expected = IllegalArgumentException.class)
    public void testCopyException2() throws IllegalArgumentException {
        CopyArray.copy(testArray, 4, 10);
    }

}