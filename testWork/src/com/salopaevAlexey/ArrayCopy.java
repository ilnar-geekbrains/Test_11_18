package com.salopaevAlexey;

import java.util.Arrays;

public class ArrayCopy<T> {
    public T[] copyArray(T[] array) {
        return Arrays.copyOf(array, array.length);
    }
}
