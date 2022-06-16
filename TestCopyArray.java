import java.util.Arrays;

public class TestCopyArray {
    public static void copyNotEmptyArrayOfIntegers() {
        String testName = Thread.currentThread().getStackTrace()[1].getMethodName();
        System.out.print("Test " + testName + "... ");
        int[] testArray = new int[] {1, 2, 3, 10, 9999999};
        int[] targetArray = CopyArray.from(testArray);
        if (Arrays.equals(testArray, targetArray))
            System.out.println("PASSED");
        else
            System.out.println("FAILED");
    }

    public static void copyEmptyArrayOfIntegers() {
        String testName = Thread.currentThread().getStackTrace()[1].getMethodName();
        System.out.print("Test " + testName + "... ");
        int[] testArray = new int[] {};
        int[] targetArray = CopyArray.from(testArray);
        if (Arrays.equals(testArray, targetArray))
            System.out.println("PASSED");
        else
            System.out.println("FAILED");
    }

    public static void copyNotEmptyArrayOfStrings() {
        String testName = Thread.currentThread().getStackTrace()[1].getMethodName();
        System.out.print("Test " + testName + "... ");
        String[] testArray = new String[] {"Mama", "Papa", "Son", "Daughter"};
        String[] targetArray = CopyArray.from(testArray);
        if (Arrays.equals(testArray, targetArray))
            System.out.println("PASSED");
        else
            System.out.println("FAILED");
    }

    public static void copyNullArrayOfStrings() {
        String testName = Thread.currentThread().getStackTrace()[1].getMethodName();
        System.out.print("Test " + testName + "... ");
        String[] testArray = null;
        String[] targetArray = CopyArray.from(testArray);
        if (Arrays.equals(testArray, targetArray))
            System.out.println("PASSED");
        else
            System.out.println("FAILED");
    }

    public static void copyArrayOfObjects() {
        class Dummy {
            public int field1;
            public String field2;
            public Dummy(int field1, String field2) {
                this.field1 = field1;
                this.field2 = field2;
            }
        }
        String testName = Thread.currentThread().getStackTrace()[1].getMethodName();
        System.out.print("Test " + testName + "... ");
        Dummy[] testArray = new Dummy[] {new Dummy(1, "Mama"), new Dummy(2, "Papa")};
        Dummy[] targetArray = CopyArray.from(testArray);
        if (Arrays.equals(testArray, targetArray))
            System.out.println("PASSED");
        else
            System.out.println("FAILED");
    }
}
