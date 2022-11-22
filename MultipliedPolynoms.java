/**
 * Задача №2 с элементами математики. Написать программу для операции "произведение массивов".
 * Сама операция определяется так, как будто элементы массива - это коэффициенты полинома. Соответственно,
 * произведение массивов - должно дать новый массив, коэффициенты которого соответсвуют нужному полиному.
 * Например, возьмем полином (x - 1) и полином (x + 2). Их можно представить в виде массивов
 * [-1, 1] и [2, 1] соответственно. Индекс элемента в массиве соответствует степени x при этом коээфициенте,
 * т.е. полином (x - 1) можно переписать как (-1 * x^0 + 1 * x^1),
 * таким образом соответсвующий этому полиному массив будет иметь вид [-1, 1].
 * По указанному правилу произведение массивов [-1, 1] и [2, 1]
 * должно быть равно [-2, 1, 1], т.к. (x - 1) * (x + 2) = (x^2 + x^1 - 2).
 */
public class MultipliedPolynoms {

    /**
     * Метод для операции "произведение массивов"
     * @param arrayFirst
     * @param arraySecond
     * @return
     */
    public static int[] multipliedPolynoms(int[] arrayFirst, int[] arraySecond) {
        if (isArrayEmpty(arrayFirst) || isArrayEmpty(arraySecond)) {
            return new int[]{0};
        }

        int length = arrayFirst.length + arraySecond.length - 1;
        int[] multipliedArray = new int[length];

        for (int k = 0; k < length; k++) {
            multipliedArray[k] = 0;
            for (int i = 0; i < arrayFirst.length; i++) {
                for (int j = 0; j < arraySecond.length; j++) {
                    if (i + j == k) {
                        multipliedArray[k] += arrayFirst[i] * arraySecond[j];
                    }
                }
            }
        }

        return multipliedArray;
    }

    //Проверяем есть ли в массиве эллементы
    private static boolean isArrayEmpty(int[] array) {
        for (int i = 0; i < array.length; i++) {
            if (array[i] != 0) {
                return false;
            }
        }
        return true;
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
