package ru.denisqq.test;

import java.lang.reflect.Array;
import java.util.Arrays;

@SuppressWarnings("unchecked")
public class ArrayCopy<T> {

    public T[] arraySystemBasedCopy(T[] sourceArray) {
        T[] newArray = (T[]) Array.newInstance(
            sourceArray.getClass().getComponentType(),
            sourceArray.length
        );

        if(sourceArray.length > 0) {
            System.arraycopy(sourceArray, 0, newArray, 0, sourceArray.length);
        }

        return newArray;
    }

    public T[] elementBasedCopy(T[] sourceArray) {
        T[] newArray = (T[]) Array.newInstance(
            sourceArray.getClass().getComponentType(),
            sourceArray.length
        );

        if(sourceArray.length > 0) {
            for (int i = 0; i < newArray.length; i++) {
                newArray[i] = sourceArray[i];
            }
        }


        return newArray;
    }
}
