package ru.geekbrains;

import org.junit.Assert;
import org.junit.Test;

public class ArrayCopyTest {

    @Test(expected = IllegalArgumentException.class)
    public void testSourceNull() {
        ArrayCopy.arrayCopy(null, new Object[10]);
    }

    @Test(expected = IllegalArgumentException.class)
    public void testDestNull() {
        ArrayCopy.arrayCopy(new Object[10], null);
    }

    @Test(expected = IllegalArgumentException.class)
    public void testDestTooShort() {
        ArrayCopy.arrayCopy(new Object[10], new Object[5]);
    }

    @Test
    public void testArrayCopy() {
        Object[] source = {1, 2, 3, 4};
        Object[] dest = new Object[5];
        ArrayCopy.arrayCopy(source, dest);
        for (int i=0; i<source.length; i++) {
            Assert.assertEquals(source[i], dest[i]);
        }
        for (int i=source.length; i<dest.length; i++) {
            Assert.assertNull(dest[i]);
        }
    }
}
