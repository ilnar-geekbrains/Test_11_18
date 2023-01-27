package util;

import java.io.Serializable;

public class SerializableTestUtil implements Serializable {
    private int id;
    private ChildSerializableTestUtil child;

    public SerializableTestUtil(int id, ChildSerializableTestUtil child) {
        this.id = id;
        this.child = child;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public ChildSerializableTestUtil getChild() {
        return child;
    }

    public void setChild(ChildSerializableTestUtil child) {
        this.child = child;
    }
}
