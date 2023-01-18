package Utils;

/**
 * Класс для проверки валидности входных параметров методов CopyArray.
 */
public class UtilsCopyArray {
    public static void validate(int rightBound, int leftBound, int arrayLength) {
        validateBound(rightBound);
        validateBound(leftBound);
        validateLeftSmallerRight(leftBound, rightBound);
        validateBoundSmallerLength(leftBound, arrayLength);
        validateBoundSmallerLength(rightBound, arrayLength);
    }

    private static void validateBound(int bound) {
        if (bound < 0) {
            throw new IllegalArgumentException("Границы копирования массива не могу иметь отрицательные значения");
        }
    }
    private static void validateLeftSmallerRight(int leftBound, int rightBound) {
        if (leftBound > rightBound) {
            throw new IllegalArgumentException("Левая граница копирования массива не может быть больше правой");
        }
    }

    private static void validateBoundSmallerLength(int bound, int length) {
        if (bound > length) {
            throw new IllegalArgumentException("Граница копирования массива не может быть больше размера массива");
        }
    }
}
