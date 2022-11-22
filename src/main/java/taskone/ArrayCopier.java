package taskone;

public class ArrayCopier {

    public int[] copy(int[] arrayToCopy) {
        if (arrayToCopy == null) {
            throw new IllegalArgumentException("Array is null");
        }

        int[] copy = new int[arrayToCopy.length];
        for (int i = 0; i < arrayToCopy.length; i++) {
            copy[i] = arrayToCopy[i];
        }
        return copy;
    }
}
