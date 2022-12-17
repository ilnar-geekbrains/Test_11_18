import java.util.Arrays;
import java.util.List;
import java.util.Optional;

public class Copy {
    public Object[] copyArray(Object[] array) {
        Object[] arrayCopy = new Object[array.length];
        for (int i =0;i<array.length;i++) {
            arrayCopy[i] = array[i];
        }
        return arrayCopy;
    }
    public Number[] multiplyArrays(Number[] array1, Number[] array2) {
        int maxLength = Integer.max(array1.length,array2.length);
        Number[] multipliedArray = new Number[maxLength*2-1];
        int i;
        int j;
        for (int k=0;k<multipliedArray.length;k++) {
            if(k<maxLength) {
                i = 0;
                j = k;
                while (i<=k) {
                    multipliedArray[k] = Optional.ofNullable(multipliedArray[k]).orElse(0).intValue() + array1[i].intValue() * array2[j].intValue();
                    i++;
                    j--;
                }
                } else {
                i = k - maxLength + 1;
                j = maxLength - 1;
                while (i<maxLength) {
                    multipliedArray[k] = Optional.ofNullable(multipliedArray[k]).orElse(0).intValue() + array1[i].intValue() * array2[j].intValue();
                    i++;
                    j--;
                }
            }}
        return multipliedArray;
    }
}
