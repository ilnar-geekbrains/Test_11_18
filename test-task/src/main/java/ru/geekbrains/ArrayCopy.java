package ru.geekbrains;

public class ArrayCopy {

    public static void arrayCopy(Object[] source, Object[] dest) {
        if (source == null) {
            throw new IllegalArgumentException("Source is null");
        }
        if (dest == null) {
            throw new IllegalArgumentException("Dest is null");
        }
        if (dest.length < source.length) {
            throw new IllegalArgumentException("Dest should be longer then Source");
        }
        for (int i=0; i < source.length; i++) {
            dest[i] = source[i];
        }
        // or System.arraycopy(source, 0, dest, 0, source.length);
    }
}
