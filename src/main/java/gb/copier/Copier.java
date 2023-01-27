package gb.copier;

@FunctionalInterface
public interface Copier<C> {
    C copy(C object);
}
