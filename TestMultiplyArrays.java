import java.util.Arrays;

public class TestMultiplyArrays {
    public static void oneArrayIsNull() {
        String testName = Thread.currentThread().getStackTrace()[1].getMethodName();
        System.out.print("Test " + testName + "... ");
        int[] source1 = new int[] {1, 2, 3};
        int[] source2 = null;
        int[] target = MultiplyArrays.ofIntegers(source1, source2);
        if (target == null)
            System.out.println("PASSED");
        else
            System.out.println("FAILED");
    }

    public static void oneArrayIsEmpty() {
        String testName = Thread.currentThread().getStackTrace()[1].getMethodName();
        System.out.print("Test " + testName + "... ");
        int[] source1 = new int[] {1, 2, 3};
        int[] source2 = new int[] {};
        int[] target = MultiplyArrays.ofIntegers(source1, source2);
        if (target != null && target.length == 0)
            System.out.println("PASSED");
        else
            System.out.println("FAILED");
    }

    public static void arrayLengthOverThreeIsIgnored() {
        String testName = Thread.currentThread().getStackTrace()[1].getMethodName();
        System.out.print("Test " + testName + "... ");
        int[] source1 = new int[] {2, 3, 4, 5, 6};
        int[] source2 = new int[] {7, 8, 9, 10, 11, 12};
        int[] expected = new int[] {14, 37, 70, 59, 36};
        int[] target = MultiplyArrays.ofIntegers(source1, source2);
        if (Arrays.equals(target, expected))
            System.out.println("PASSED");
        else
            System.out.println("FAILED");
    }

    public static void lengthOfBothArraysIsLessThanThree() {
        String testName = Thread.currentThread().getStackTrace()[1].getMethodName();
        System.out.print("Test " + testName + "... ");
        int[] source1 = new int[] {2, 3};
        int[] source2 = new int[] {4};
        int[] expected = new int[] {8, 12, 0, 0, 0};
        int[] target = MultiplyArrays.ofIntegers(source1, source2);
        if (Arrays.equals(target, expected))
            System.out.println("PASSED");
        else
            System.out.println("FAILED");
    }

    public static void negativeNumbers() {
        String testName = Thread.currentThread().getStackTrace()[1].getMethodName();
        System.out.print("Test " + testName + "... ");
        int[] source1 = new int[] {2, -3, 4};
        int[] source2 = new int[] {-7, 8, 9};
        int[] expected = new int[] {-14, 37, -34, 5, 36};
        int[] target = MultiplyArrays.ofIntegers(source1, source2);
        if (Arrays.equals(target, expected))
            System.out.println("PASSED");
        else
            System.out.println("FAILED");
    }
}
