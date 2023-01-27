package copier;

import gb.copier.Copier;
import gb.copier.impl.ArrayCopier;
import org.junit.jupiter.api.Test;
import util.ChildSerializableTestUtil;
import util.SerializableTestUtil;

import static org.junit.jupiter.api.Assertions.*;

public class ArrayCopierTests {

    @Test
    void copy_test() {
        Copier<SerializableTestUtil[]> copier = new ArrayCopier<>();
        ChildSerializableTestUtil child = new ChildSerializableTestUtil(1);

        SerializableTestUtil firstSerializable = new SerializableTestUtil(1, child);
        SerializableTestUtil secondSerializable = new SerializableTestUtil(2, child);
        SerializableTestUtil thirdSerializable = new SerializableTestUtil(3, child);

        SerializableTestUtil[] serializable =
                new SerializableTestUtil[]{firstSerializable, secondSerializable, thirdSerializable};

        SerializableTestUtil[] copySerializable = copier.copy(serializable);

        assertNotEquals(serializable, copySerializable);
        assertNotEquals(serializable[1].getChild(), copySerializable[1].getChild());
        assertEquals(serializable[1].getId(), copySerializable[1].getId());
    }

    @Test
    void copy_when_primitive_in_generic() {
        Copier copier = new ArrayCopier<>();
        int[] primitives = new int[]{1, 2, 3};
        assertThrows(ClassCastException.class, () -> copier.copy(primitives));
    }
}
