package gb.copier.impl;

import gb.copier.Copier;
import gb.exception.GBNotSerializableException;

import java.io.*;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class ObjectCopier<O> implements Copier<O> {

    public O copy (O object) {
        try {
            if(isSerializable(object)) {
                ByteArrayOutputStream byteOutputStream = new ByteArrayOutputStream();
                ObjectOutputStream out = new ObjectOutputStream(byteOutputStream);
                out.writeObject(object);
                ByteArrayInputStream byteInputStream = new ByteArrayInputStream(byteOutputStream.toByteArray());
                ObjectInputStream in = new ObjectInputStream(byteInputStream);
                return (O) in.readObject();
            } else {
                throw new GBNotSerializableException(
                        String.format(
                                "Class object %s does not inherit from Serializable interface",
                                object.getClass().getSimpleName()
                        )
                );
            }

        } catch (ClassNotFoundException | IOException e) {
            throw new RuntimeException(e);
        }
    }

    private boolean isSerializable(O object) {
        List<Class<?>> interfaces = getInterfaces(object);
        return interfaces.contains(Serializable.class);
    }

    private List<Class<?>> getInterfaces(O object) {
        Class<?> cls = object.getClass();
        List<Class<?>> interfaces = new ArrayList<>(Arrays.asList(cls.getInterfaces()));
        while (cls.getSuperclass() != null) {
            cls = cls.getSuperclass();
            interfaces.addAll(Arrays.asList(cls.getInterfaces()));
        }
        return interfaces;
    }

}
