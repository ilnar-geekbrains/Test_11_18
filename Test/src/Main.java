import java.util.Arrays;


public class Main {

    /*
    Задача №2 с элементами математики.
    Написать программу для операции "произведение массивов". Сама операция определяется так, как будто элементы массива - это
    коэффициенты полинома. Соответственно, произведение массивов - должно дать новый массив, коэффициенты которого соответсвуют нужному полиному.
    Например, возьмем полином (x - 1) и полином (x + 2). Их можно представить в виде массивов [-1, 1] и [2, 1] соответственно.
    Индекс элемента в массиве соответствует степени x при этом коээфициенте, т.е. полином (x - 1) можно переписать как
    (-1 * x^0 + 1 * x^1), таким образом соответсвующий этому полиному массив будет иметь вид [-1, 1].
    По указанному правилу произведение массивов [-1, 1] и [2, 1] должно быть равно [-2, 1, 1], т.к. (x - 1) * (x + 2) =
    (x^2 + x^1 - 2).
     */

    public static void main(String[] args) {
        int[] expected = {-2, 1, 1};
        int[] arr1 = {-1, 1};
        int[] arr2 = {2, 1};
        int[] actual = ArrayMultiplier.multiply(arr1, arr2);
        assert Arrays.equals(expected, actual);

        actual = ArrayMultiplier.multiply(null, null);
        assert actual == null;

        expected = new int[]{18, 7, 64, -6, 7, 0};
        arr1 = new int[]{9, -1, 1};
        arr2 = new int[]{2, 1, 7, 0};
        actual = ArrayMultiplier.multiply(arr1, arr2);
        assert Arrays.equals(expected, actual);

        expected = new int[]{0, 0, 0};
        arr1 = new int[]{9, -1, 1};
        arr2 = new int[]{0};
        actual = ArrayMultiplier.multiply(arr1, arr2);
        assert Arrays.equals(expected, actual);

    }
}