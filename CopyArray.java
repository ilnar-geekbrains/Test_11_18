// This is the implementation of Task 1 from the test task
// Test cases are written in TestCopyArray class

import java.lang.reflect.Array;

// Perform a deep copy of one array into another
public class CopyArray<T> {
    public static <T> T[] from(T[] source) {
        if (source == null)
            return null;
        int arrayLength = source.length;
        Class<?> arrayType = source.getClass().getComponentType();
        T[] target = (T[])Array.newInstance(arrayType, arrayLength);
        System.arraycopy(source, 0, target, 0, arrayLength);
        return target;
    }

    public static int[] from(int[] source) {
        if (source == null)
            return null;
        int arrayLength = source.length;
        int[] target = new int[arrayLength];
        System.arraycopy(source, 0, target, 0, arrayLength);
        return target;
    }

    public static String[] from(String[] source) {
        if (source == null)
            return null;
        int arrayLength = source.length;
        String[] target = new String[arrayLength];
        System.arraycopy(source, 0, target, 0, arrayLength);
        return target;
    }
}
