package ru.spb;

import java.lang.reflect.Array;

public class FirstProblem {

    /**
     * You just can you some of Java Api methods to copy an array
     * For example:
     * Arrays.copyOf() with its different overloads and System.arraycopy();
     */
    public static Object[] copyArray(Object[] sourceArray) {
        if (!sourceArray.getClass().isArray()) {
            throw new RuntimeException("Passed parameter 'sourceArray' is not array");
        }

        if (sourceArray.length == 0) {
            throw new RuntimeException("Passed array is empty, nothing to copy");
        }

        var targetArray = (Object[]) Array.newInstance(sourceArray.getClass().getComponentType(), sourceArray.length);
        for (int i = 0; i < sourceArray.length; i++) {
            targetArray[i] = sourceArray[i];
        }

        return targetArray;
    }
}
