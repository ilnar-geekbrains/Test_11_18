/**
 * Задача №1. Написать программу для копирования массива.
 */
public class CopyOfArray {

    /**
     *  Метод для копирования массивов
     * @param array
     * @return int[]
     */
    public static int[] copyArray(int[] array) {
        int[] copiedArray = new int[array.length];

        for (int i = 0; i < array.length; i++) {
            copiedArray[i] = array[i];
        }

        return copiedArray;
    }

    //Метод для сравнение массивов
    private static boolean isArraysEquals(int[] arrayFirst, int[] arraySecond) {
        if (arrayFirst.length != arraySecond.length) {
            return false;
        }

        for (int i = 0; i < arrayFirst.length; i++) {
            if (arrayFirst[i] != arraySecond[i]) {
                return false;
            }
        }

        return true;
    }

    //Метод для распечатывания результата проверки массивов
    public static void printResult(int[] answerPolynom, int[] multipliedPolynom) {
        if (isArraysEquals(multipliedPolynom, answerPolynom)) {
            System.out.println("Пройден успешно.");
        } else {
            System.out.println("Не пройден.");
        }
    }
}
