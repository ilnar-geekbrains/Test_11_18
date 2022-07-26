package ru.dap.array;

import java.util.Objects;

/**
 * @author dapodshivalov
 */
public class IntegerArrayProductOperation {
    /**
     * Oперация "произведение массивов".
     * Сама операция определяется так,
     * как будто элементы массива - это коэффициенты полинома.
     * Соответственно, произведение массивов - новый массив,
     * коэффициенты которого соответсвуют нужному полиному.
     *
     * Например, возьмем полином (x - 1) и полином (x + 2).
     * Их можно представить в виде массивов [-1, 1] и [2, 1] соответственно.
     * Индекс элемента в массиве соответствует степени x при этом коээфициенте,
     * т.е. полином (x - 1) можно переписать как (-1 * x^0 + 1 * x^1),
     * таким образом соответсвующий этому полиному массив будет иметь вид [-1, 1].
     *
     * По указанному правилу произведение массивов [-1, 1] и [2, 1]
     * должно быть равно [-2, 1, 1], т.к. (x - 1) * (x + 2) = (x^2 + x^1 - 2).
     *
     * @param left is for left-hand array of arrays product operation
     * @param right is for right-hand array of arrays product operation
     * @return arrays product if arguments are not {@code null} nor empty
     * @throws NullPointerException if {@code left} or {@code right} is {@code null}
     * @throws IllegalArgumentException if {@code left} or {@code right} is empty
     */
    public int[] apply(int[] left, int[] right) {
        check(left, right);

        int[] resultInt = new int[right.length + left.length - 1];

        for (int i = 0; i < left.length; i++) {
            for (int j = 0; j < right.length; j++) {
                resultInt[i + j] += left[i] * right[j];
            }
        }
        return resultInt;
    }

    private static void check(int[] left, int[] right) {
        Objects.requireNonNull(left, "left array is null");
        Objects.requireNonNull(right, "right array is null");
        if (left.length == 0 || right.length == 0) {
            throw new IllegalArgumentException("Don't support product operation for empry array");
        }
    }
}
