using System;


namespace Problem
{
    class Program
    {
        //Задача № 2.
        //Перемножение полиномов, выраженных в виде массивов их коэффициентов.

        static bool IsZerosArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsArraysEquals(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }

        static int[] GetMultipliedPolynoms(int[] polynom1, int[] polynom2)
        {
            if (IsZerosArray(polynom1) || IsZerosArray(polynom2))
            {
                return new int[] { 0 };
            }

            int n = polynom1.Length + polynom2.Length - 1;
            int[] multipliedPolynom = new int[n];

            for (int k = 0; k < n; k++)
            {
                multipliedPolynom[k] = 0;
                for (int i = 0; i < polynom1.Length; i++)
                {
                    for (int j = 0; j < polynom2.Length; j++)
                    {
                        if (i + j == k)
                        {
                            multipliedPolynom[k] += polynom1[i] * polynom2[j];
                        }
                    }
                }
            }

            return multipliedPolynom;
        }

        static void Main(string[] args)
        {
            //Test 1
            {
                int[] polynom1 = { -1, 1 };
                int[] polynom2 = { 2, 1 };

                // (x - 1)(x + 2) = (x^2 + x - 2)
                int[] answerPolynom = { -2, 1, 1 }; 

                int[] multipliedPolynom = GetMultipliedPolynoms(polynom1, polynom2);

                if (IsArraysEquals(multipliedPolynom, answerPolynom))
                {
                    Console.WriteLine("Тест пройден.");
                }
                else
                {
                    Console.WriteLine("Тест не пройден.");
                }
            }

            //Test 2
            {
                int[] polynom1 = { 1, 1 };
                int[] polynom2 = { 1, 1 };

                // (x + 1)(x + 1) = (x^2 + 2x + 1)
                int[] answerPolynom = { 1, 2, 1 }; 

                int[] multipliedPolynom = GetMultipliedPolynoms(polynom1, polynom2);

                if (IsArraysEquals(multipliedPolynom, answerPolynom))
                {
                    Console.WriteLine("Тест пройден.");
                }
                else
                {
                    Console.WriteLine("Тест не пройден.");
                }
            }

            //Test 3
            {
                int[] polynom1 = { 5, -3, 4 };
                int[] polynom2 = { -7, 2, -2 };

                // (4x^2 - 3x + 5)(-2x^2 + 2x - 7) = (-8x^4 + 14x^3 - 44x^2 + 31x - 35)
                int[] answerPolynom = { -35, 31, -44, 14, -8 }; 

                int[] multipliedPolynom = GetMultipliedPolynoms(polynom1, polynom2);

                if (IsArraysEquals(multipliedPolynom, answerPolynom))
                {
                    Console.WriteLine("Тест пройден.");
                }
                else
                {
                    Console.WriteLine("Тест не пройден.");
                }
            }

            //Test 4
            {
                int[] polynom1 = { -1 };
                int[] polynom2 = { 1 };

                // 1 * (-1) = -1
                int[] answerPolynom = { -1 };

                int[] multipliedPolynom = GetMultipliedPolynoms(polynom1, polynom2);

                if (IsArraysEquals(multipliedPolynom, answerPolynom))
                {
                    Console.WriteLine("Тест пройден.");
                }
                else
                {
                    Console.WriteLine("Тест не пройден.");
                }
            }

            //Test 5
            {
                int[] polynom1 = { 0 };
                int[] polynom2 = { 1, 1, 1};

                // 0 * (x^2 + x + 1) = 0
                int[] answerPolynom = { 0 };

                int[] multipliedPolynom = GetMultipliedPolynoms(polynom1, polynom2);

                if (IsArraysEquals(multipliedPolynom, answerPolynom))
                {
                    Console.WriteLine("Тест пройден.");
                }
                else
                {
                    Console.WriteLine("Тест не пройден.");
                }
            }

        }

    }
}
