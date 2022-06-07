package ru.geekbrains;

import org.junit.Assert;
import org.junit.Test;

public class PolynomialProductionTest {

    @Test(expected = IllegalArgumentException.class)
    public void testFirstPolyIsNull() {
        PolynomialProduction.multiply(null, new int[]{2});
    }

    @Test(expected = IllegalArgumentException.class)
    public void testSecondPolyIsNull() {
        PolynomialProduction.multiply(new int[]{-1}, null);
    }

    @Test
    public void testCaseOne() {
        int[] res = PolynomialProduction.multiply(new int[]{-1}, new int[]{2});
        Assert.assertArrayEquals(new int[] {-2}, res);
    }

    @Test
    public void testCaseTwo() {
        int[] res = PolynomialProduction.multiply(new int[]{-1, 1}, new int[]{2, 1});
        Assert.assertArrayEquals(new int[] {-2, 1, 1}, res);
    }

    @Test
    public void testCaseTree() {
        int[] res = PolynomialProduction.multiply(new int[]{-1, 1, 1}, new int[]{2, 1});
        Assert.assertArrayEquals(new int[] {-2, 1, 3, 1}, res);
    }

    @Test
    public void testCaseFour() {
        int[] res = PolynomialProduction.multiply(new int[]{2, 1}, new int[]{-1, 1, 1});
        Assert.assertArrayEquals(new int[] {-2, 1, 3, 1}, res);
    }
}
