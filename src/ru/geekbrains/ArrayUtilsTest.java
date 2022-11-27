package ru.geekbrains;

import static ru.geekbrains.Asserts.assertEquals;
import static ru.geekbrains.Asserts.assertNotTheSame;

class ArrayUtilsTest {

    public static void run() {
        copyArray1_srcArrayIsNull_IllegalArgumentException();
        copyArray1_srcArrayIsEmpty_successCopy();
        copyArray1_srcArrayIsNotEmpty_successCopy();

        copyArray2_srcArrayIsNull_IllegalArgumentException();
        copyArray2_srcArrayIsEmpty_successCopy();
        copyArray2_srcArrayIsNotEmpty_successCopy();

        copyArray3_srcArrayIsNull_IllegalArgumentException();
        copyArray3_srcArrayIsEmpty_successCopy();
        copyArray3_srcArrayIsNotEmpty_successCopy();

        copyArray4_srcArrayIsNull_IllegalArgumentException();
        copyArray4_srcArrayIsEmpty_successCopy();
        copyArray4_srcArrayIsNotEmpty_successCopy();
    }

    private static void copyArray1_srcArrayIsNull_IllegalArgumentException() {
        log("copyArray1_srcArrayIsNull_IllegalArgumentException: fired ..");
        try {
            ArrayUtils.copyArray1(null);
        } catch (IllegalArgumentException e) {
            log("copyArray1_srcArrayIsNull_IllegalArgumentException: ok");
        }
    }

    private static void copyArray1_srcArrayIsEmpty_successCopy() {
        log("copyArray1_srcArrayIsEmpty_successCopy: fired ..");
        var emptySrcArray = new String[]{};
        var copyArray = ArrayUtils.copyArray1(emptySrcArray);

        assertNotTheSame(emptySrcArray, copyArray);
        assertEquals(emptySrcArray, copyArray);
        log("copyArray1_srcArrayIsEmpty_successCopy: ok");
    }

    private static void copyArray1_srcArrayIsNotEmpty_successCopy() {
        log("copyArray1_srcArrayIsNotEmpty_successCopy: fired ..");
        var srcArray = new String[]{"orange", "red", "green'"};
        var copyArray = ArrayUtils.copyArray1(srcArray);

        assertNotTheSame(srcArray, copyArray);
        assertEquals(srcArray, copyArray);
        log("copyArray1_srcArrayIsNotEmpty_successCopy: ok");
    }

    private static void copyArray2_srcArrayIsNull_IllegalArgumentException() {
        log("copyArray2_srcArrayIsNull_IllegalArgumentException: fired ..");
        try {
            ArrayUtils.copyArray2(null);
        } catch (IllegalArgumentException e) {
            log("copyArray2_srcArrayIsNull_IllegalArgumentException: ok");
        }
    }

    private static void copyArray2_srcArrayIsEmpty_successCopy() {
        log("copyArray2_srcArrayIsEmpty_successCopy: fired ..");
        var emptySrcArray = new String[]{};
        var copyArray = ArrayUtils.copyArray2(emptySrcArray);

        assertNotTheSame(emptySrcArray, copyArray);
        assertEquals(emptySrcArray, copyArray);
        log("copyArray2_srcArrayIsEmpty_successCopy: ok");
    }

    private static void copyArray2_srcArrayIsNotEmpty_successCopy() {
        log("copyArray2_srcArrayIsNotEmpty_successCopy: fired ..");
        var srcArray = new String[]{"orange", "red", "green'"};
        var copyArray = ArrayUtils.copyArray2(srcArray);

        assertNotTheSame(srcArray, copyArray);
        assertEquals(srcArray, copyArray);
        log("copyArray2_srcArrayIsNotEmpty_successCopy: ok");
    }

    private static void copyArray3_srcArrayIsNull_IllegalArgumentException() {
        log("copyArray3_srcArrayIsNull_IllegalArgumentException: fired ..");
        try {
            ArrayUtils.copyArray3(null);
        } catch (IllegalArgumentException e) {
            log("copyArray3_srcArrayIsNull_IllegalArgumentException: ok");
        }
    }

    private static void copyArray3_srcArrayIsEmpty_successCopy() {
        log("copyArray3_srcArrayIsEmpty_successCopy: fired ..");
        var emptySrcArray = new String[]{};
        var copyArray = ArrayUtils.copyArray3(emptySrcArray);

        assertNotTheSame(emptySrcArray, copyArray);
        assertEquals(emptySrcArray, copyArray);
        log("copyArray3_srcArrayIsEmpty_successCopy: ok");
    }

    private static void copyArray3_srcArrayIsNotEmpty_successCopy() {
        log("copyArray3_srcArrayIsNotEmpty_successCopy: fired ..");
        var srcArray = new String[]{"orange", "red", "green'"};
        var copyArray = ArrayUtils.copyArray3(srcArray);

        assertNotTheSame(srcArray, copyArray);
        assertEquals(srcArray, copyArray);
        log("copyArray3_srcArrayIsNotEmpty_successCopy: ok");
    }

    private static void copyArray4_srcArrayIsNull_IllegalArgumentException() {
        log("copyArray4_srcArrayIsNull_IllegalArgumentException: fired ..");
        try {
            ArrayUtils.copyArray4(null);
        } catch (IllegalArgumentException e) {
            log("copyArray4_srcArrayIsNull_IllegalArgumentException: ok");
        }
    }

    private static void copyArray4_srcArrayIsEmpty_successCopy() {
        log("copyArray4_srcArrayIsEmpty_successCopy: fired ..");
        var emptySrcArray = new String[]{};
        var copyArray = ArrayUtils.copyArray4(emptySrcArray);

        assertNotTheSame(emptySrcArray, copyArray);
        assertEquals(emptySrcArray, copyArray);
        log("copyArray4_srcArrayIsEmpty_successCopy: ok");
    }

    private static void copyArray4_srcArrayIsNotEmpty_successCopy() {
        log("copyArray4_srcArrayIsNotEmpty_successCopy: fired ..");
        var srcArray = new String[]{"orange", "red", "green'"};
        var copyArray = ArrayUtils.copyArray4(srcArray);

        assertNotTheSame(srcArray, copyArray);
        assertEquals(srcArray, copyArray);
        log("copyArray4_srcArrayIsNotEmpty_successCopy: ok");
    }

    private static void log(String msg) {
        System.out.println(msg);
    }
}