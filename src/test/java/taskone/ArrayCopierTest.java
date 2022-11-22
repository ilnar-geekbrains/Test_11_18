package taskone;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

public class ArrayCopierTest {

    ArrayCopier arrayCopier = new ArrayCopier();

    @Test
    void testCopy_ArrayIsCopied() {
        int[] arr = {1,2,3};

        var copy = arrayCopier.copy(arr);

        assertNotEquals(arr, copy);
        assertArrayEquals(arr, copy);
    }

    @Test
    void testCopy_ArrayIsNull_ThrowException(){
        int[] arr = null;

        assertThrows(IllegalArgumentException.class, () -> arrayCopier.copy(arr));
    }
}
