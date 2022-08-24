namespace Test_11_18;

public class ArrayHelper
{
    public static double[] MultiplyPolynomials(double[] a, double[] b)
    {
        ArgumentNullException.ThrowIfNull(a);
        ArgumentNullException.ThrowIfNull(b);

        double[] result = new double[a.Length + b.Length - 1];

        for (int i = 0; i < a.Length; i++)
            for (int j = 0; j < b.Length; j++)
                result[i + j] += a[i] * b[j];

        return result;
    }
}
