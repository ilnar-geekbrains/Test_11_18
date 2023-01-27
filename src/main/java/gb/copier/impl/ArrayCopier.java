package gb.copier.impl;

import gb.copier.Copier;

import java.util.stream.IntStream;

public class ArrayCopier<O> implements Copier<O[]> {

    private final ObjectCopier<O> copier;
    public ArrayCopier() {
        this.copier = new ObjectCopier<>();
    }

    @Override
    public O[] copy(O[] array) {
        O[] result = array.clone();
        IntStream.range(0, array.length).forEach(i -> result[i] = copier.copy(array[i]));
        return result;
    }
}
