using System;

class Polynom
{
    public static int[] PolynomMultiplier(int[] first_polynom, int[] second_polynom)
    {
        if(first_polynom.Length = 0 || second_polynom.Length = 0)
        {
            return;
        }

        int[] polynom_product = new int[first_polynom.Length + second_polynom.Lenth - 1];

        for(int i = 0; i < first_polynom.Length; i++)
        {
            for(int j = 0; j < second_polynom.Length; j++)
            {
                polynom_product[i + j] = first_polynom[i] + second_polynom[j];
            }
        }

        return polynom_product;
    }
}

