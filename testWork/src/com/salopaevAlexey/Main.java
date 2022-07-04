package com.salopaevAlexey;

public class Main {
    private static final ArrayCopy<String> copyStringArray = new ArrayCopy<>();
    private static final ArrayCopy<Integer> copyIntArray = new ArrayCopy<>();
    private static final String[] arrayOfString = new String[]{"test1", "test2", "test3", "test4"};
    private static final Integer[] arrayOfInts = new Integer[]{1, 2, 3, 4, 5};

    public static void main(String[] args) {
        if (copyOfStringArray() && copyOfIntsArray()) {
            System.out.println("Программа работает верно");
        } else {
            System.out.println("Массив копируеться не верно");
        }
    }

    private static boolean copyOfStringArray() {
        String[] newArrayOfString = copyStringArray.copyArray(arrayOfString);
        return newArrayOfString[0].equals(arrayOfString[0]);
    }

    private static boolean copyOfIntsArray() {
        Integer[] newArrayOfInts = copyIntArray.copyArray(arrayOfInts);
        return newArrayOfInts[0].equals(arrayOfInts[0]);
    }
}
