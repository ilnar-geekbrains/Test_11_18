using System;
using System.Linq;

class Polynom
{
    public static int[] PolynomMultiplier(int[] first_polynom, int[] second_polynom)
    {
        int[] polynomProduct = new int[first_polynom.Length + second_polynom.Length - 1];

        for(int i = 0; i < first_polynom.Length; i++)
        {
            for(int j = 0; j < second_polynom.Length; j++)
            {
                polynomProduct[i + j] += first_polynom[i] * second_polynom[j];
            }
        }

        return polynomProduct;
    }
}

class PolynomMultiplierTests
{
    public static void Main()
    {
    if(BasicTest())
    {
        Console.WriteLine("Passed");
    }
    else
    {
        Console.WriteLine("Failed");
    }
    
    if(!NegativeTest())
    {
        Console.WriteLine("Passed");
    }
    else
    {
        Console.WriteLine("Failed");
    }
    
    if(DifferentLengthTest())
    {
        Console.WriteLine("Passed");
    }
    else
    {
        Console.WriteLine("Failed");
    }
    if(BothZeroesTest())
    {
        Console.WriteLine("Passed");
    }
    else
    {
        Console.WriteLine("Failed");
    }
    if(OneZeroeTest())
    {
        Console.WriteLine("Passed");
    }
    else
    {
        Console.WriteLine("Failed");
    }
    }

    static bool BasicTest()
    {
        int[] first_polynom = {-1, 1};
        int[] second_polynom = {2, 1};
        int[] expected = {-2, 1, 1};
        int[] actual = Polynom.PolynomMultiplier(first_polynom, second_polynom);
        return expected.SequenceEqual(actual);
    }
    static bool NegativeTest()
    {
        int[] first_polynom = {-1, 1};
        int[] second_polynom = {2, 1};
        int[] expected = {-2, 2, 2};
        int[] actual = Polynom.PolynomMultiplier(first_polynom, second_polynom);
        return expected.SequenceEqual(actual);
    }

    static bool DifferentLengthTest()
    {
        int[] first_polynom = {1, 2, 9, 3};
        int[] second_polynom = {2, 7};
        int[] expected = {2, 11, 32, 69, 21};
        int[] actual = Polynom.PolynomMultiplier(first_polynom, second_polynom);
        return expected.SequenceEqual(actual);
    }
    static bool BothZeroesTest()
    {
        int[] first_polynom = {0};
        int[] second_polynom = {0};
        int[] expected = {0};
        int[] actual = Polynom.PolynomMultiplier(first_polynom, second_polynom);
        return expected.SequenceEqual(actual);
    }
    static bool OneZeroeTest()
    {
        int[] first_polynom = {0};
        int[] second_polynom = {0};
        int[] expected = {0};
        int[] actual = Polynom.PolynomMultiplier(first_polynom, second_polynom);
        return expected.SequenceEqual(actual);
    }
}