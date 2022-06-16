// This is the implementation of Task 2 the test task
// Test cases are written in TestMultiplyArrays class
// Formula is the following:
// (a + bx + cx^2) * (d + ex + fx^2) = ad + (ae + bd)x + (af + be + cd)x^2 + (bf + ce)x^3 + cfx^4
// index0 = ad
// index1 = ae + bd
// index2 = af + be + cd
// index3 = bf + ce
// index4 = cf
public class MultiplyArrays {
    public static int[] ofIntegers(int[] source1, int[] source2) {
        if (source1 == null || source2 == null)
            return null;
        if (source1.length == 0 || source2.length == 0 )
            return new int[] {};
        int a, b, c, d, e, f;
        a = source1[0];
        try {
            b = source1[1];
        }
        catch (Exception ex) {
            b = 0;
        }
        try {
            c = source1[2];
        }
        catch (Exception ex) {
            c = 0;
        }
        d = source2[0];
        try {
            e = source2[1];
        }
        catch (Exception ex) {
            e = 0;
        }
        try {
            f = source2[2];
        }
        catch (Exception ex) {
            f = 0;
        }
        int[] target = new int[5];
        target[0] = a * d;
        target[1] = a * e + b * d;
        target[2] = a * f + b * e + c * d;
        target[3] = b * f + c * e;
        target[4] = c * f;
        return target;
    }
}
