using System;

namespace Test_11_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var polynom1 = new Polynom(new int[] { -1, 1 });
            var polynom2 = new Polynom(new int[] { 2, 1 });
            var polynomRes = new Polynom(new int[] { -2, 1, 1 });

            if (polynomRes.Equals((polynom1.Multiply(polynom2))))
                Console.WriteLine("Тест пройден");
            else
                Console.WriteLine("Тест провален");

            if (new Polynom(new int[] { -1, 0, 1 }).Equals(new Polynom(new int[] { -1, 1 }).Multiply(new Polynom(new int[] { 1, 1 }))))
                Console.WriteLine("Тест пройден");
            else
                Console.WriteLine("Тест провален");

            if (new Polynom(new int[] { 15, 19, 14, 40 }).Equals(new Polynom(new int[] { 3, 5 }).Multiply(new Polynom(new int[] { 5, -2, 8 }))))
                Console.WriteLine("Тест пройден");
            else
                Console.WriteLine("Тест провален");

            if (new Polynom(new int[] { 2, -3, -2, 1, -2 }).Equals(new Polynom(new int[] { -1, 1, 2 }).Multiply(new Polynom(new int[] { -2, 1, -1 }))))
                Console.WriteLine("Тест пройден");
            else
                Console.WriteLine("Тест провален");

            if (new Polynom(new int[] { -7, -22, 7, -33, -12, 19, -6 }).Equals(new Polynom(new int[] { -7, -1, 3, -1 }).Multiply(new Polynom(new int[] { 1, 3, -1, 6 }))))
                Console.WriteLine("Тест пройден");
            else
                Console.WriteLine("Тест провален");

            if (new Polynom(new int[] { 10, -29, 8, 9, -16, 15 }).Equals(new Polynom(new int[] { -5, 2, 1, -2, 3 }).Multiply(new Polynom(new int[] { -2, 5 }))))
                Console.WriteLine("Тест пройден");
            else
                Console.WriteLine("Тест провален");
        }
    }
}