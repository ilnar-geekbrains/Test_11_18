package copier;

import gb.copier.Copier;
import gb.copier.impl.ObjectCopier;
import gb.exception.GBNotSerializableException;
import org.junit.jupiter.api.Test;
import util.ChildSerializableTestUtil;
import util.NotSerializableTestUtil;
import util.SerializableTestUtil;

import static org.junit.jupiter.api.Assertions.*;

public class ObjectCopierTests {

    @Test
    void copy_test() {
        Copier<SerializableTestUtil> copier = new ObjectCopier<>();

        ChildSerializableTestUtil firstChild = new ChildSerializableTestUtil(1);

        SerializableTestUtil serializable = new SerializableTestUtil(1, firstChild);
        SerializableTestUtil copySerializable = copier.copy(serializable);

        assertNotEquals(serializable, copySerializable);
        assertNotEquals(serializable.getChild(), copySerializable.getChild());
        assertEquals(serializable.getId(), copySerializable.getId());

        copySerializable.setId(3);

        assertEquals(copySerializable.getId(), 3);
        assertNotEquals(copySerializable.getId(), serializable.getId());
    }

    @Test
    void copy_when_not_serializable_object_test() {
        Copier<NotSerializableTestUtil> copier = new ObjectCopier<>();
        NotSerializableTestUtil arg = new NotSerializableTestUtil();
        assertThrows(GBNotSerializableException.class, () -> copier.copy(arg));
    }
}
