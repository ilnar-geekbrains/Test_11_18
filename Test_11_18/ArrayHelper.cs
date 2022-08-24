namespace Test_11_18;

public class ArrayHelper
{
    public static double[] MultiplyPolynomials(double[] a, double[] b)
    {
        ArgumentNullException.ThrowIfNull(a);
        ArgumentNullException.ThrowIfNull(b);

        double[] result = new double[a.Length + b.Length - 1];

        Parallel.For(0, a.Length, (i) =>
        {
            Parallel.For(0, b.Length, (j) =>
            {
                result[i + j] += a[i] * b[j];
            });
        });

        return result;
    }
}
