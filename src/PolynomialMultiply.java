package src;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertArrayEquals;
import static org.junit.jupiter.api.Assertions.assertThrows;

public class PolynomialMultiply {

    public int[] multiply(int[] firstPolynomial, int[] secondPolynomial) {
        validator(firstPolynomial);
        validator(secondPolynomial);
        int[] result = new int[firstPolynomial.length + secondPolynomial.length - 1];
        for (int i = 0; i < firstPolynomial.length; i++) {
            for (int j = 0; j < secondPolynomial.length; j++) {
                int similarityDegree = (firstPolynomial.length - 1 - i) + (secondPolynomial.length - 1 - j);
                result[result.length - similarityDegree - 1] += firstPolynomial[i] * secondPolynomial[j];
            }
        }
        return result;
    }

    public void validator(int[] polynomial) {
        if (polynomial == null || polynomial.length == 0) {
            throw new IllegalArgumentException("Enter your polynomial");
        }
        if (polynomial[polynomial.length - 1] == 0) {
            throw new IllegalArgumentException("The coefficient at the highest degree must be different from zero");
        }
    }

    @Test
    public void test(){
        assertThrows(IllegalArgumentException.class, ()-> {
            multiply(null, new int[]{1, 1});
        });
        assertThrows(IllegalArgumentException.class, ()-> {
            multiply(new int[]{1,-1,0}, new int[]{1, 1});
        });
        assertArrayEquals(new int[]{-1,-1,5,2}, multiply(new int[]{-1,2}, new int[]{1,3,1}));
        assertArrayEquals(new int[]{2,-4,2}, multiply(new int[]{1,-1}, new int[]{2,-2}));
        assertArrayEquals(new int[]{2,-2}, multiply(new int[]{1,-1}, new int[]{2}));
        assertArrayEquals(new int[]{2,-6,-3,9,4,-12}, multiply(new int[]{2,0,-3,0,4}, new int[]{1,-3}));
    }
}
