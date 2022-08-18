using System;

namespace GeekBrainsTest
{
    public class PolynomialMultiplicationOperation
    {
        public double[] Multiply(double[] source, double[] multiplierPolynom)
        {
            if(source== null)
                throw new ArgumentNullException(nameof(source));

           if (multiplierPolynom == null)
                throw new ArgumentNullException(nameof(multiplierPolynom));

            double[] largePolynom;
            double[] smallPolynom;

            if (source.Length > multiplierPolynom.Length)
            {
                largePolynom = source;
                smallPolynom = multiplierPolynom;
            }
            else
            {
                largePolynom = multiplierPolynom;
                smallPolynom = source;
            }

            int newPlynomLenght = multiplierPolynom.Length + source.Length - 1;

            double[] newPlynom = new double[newPlynomLenght];
            for (int degree = 0; degree < newPlynomLenght; degree++)
            {
                var index  = newPlynomLenght - degree - 1;
                newPlynom[degree] = GetCoef(degree, largePolynom, smallPolynom);
            }

            return newPlynom;
        }

        public double GetCoef(int degree, double[] largePolynom, double[] smallPolynom)
        {
            double sum = 0;

            for (int i = 0; i <= Math.Min(degree, smallPolynom.Length -1); i++)
            {
                int multIndex = degree - i;

                if (multIndex >= largePolynom.Length)
                    continue;

                sum += smallPolynom[i] * largePolynom[multIndex];
            }

            return sum;
        }
    }
}
