using System;
using System.Linq;

namespace Test_11_18
{
    public class Polynom
    {
        public int[] Coefficients { get; }

        public Polynom(int[] coefficients)
        {
            if (coefficients == null)
                throw new NullReferenceException(nameof(coefficients));
            Coefficients = coefficients;
        }
        public Polynom Multiply(Polynom pol)
        {
            return Multiply2Polynoms(this, pol);
        }

        public static Polynom Multiply2Polynoms(Polynom pol1, Polynom pol2)
        {
            return new Polynom(Multiply2Polynoms(pol1.Coefficients, pol2.Coefficients));
        }

        public override bool Equals(object o)
        {
            return (o as Polynom)?.Coefficients.SequenceEqual(Coefficients) ?? false;
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public static int[] Multiply2Polynoms(int[] pol1, int[] pol2)
        {
            var newPolynomCoefs = new int[pol1.Length + pol2.Length - 1];

            for (int i = 0; i < pol1.Length; i++)
            {
                for (int j = 0; j < pol2.Length; j++)
                {
                    newPolynomCoefs[i + j] += pol1[i] * pol2[j];
                }
            }
            return newPolynomCoefs;
        }
    }
}