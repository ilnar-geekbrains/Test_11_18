using System;

namespace Test
{
    class Program
    {
        public static int[] GetMultyplyPolynom(int[] polynom1, int[] polynom2)
        {
            int[] resultPolynom;
            if ((polynom1 == null) || (polynom2 == null))
                return new int[0];

            if ((polynom1.Length == 1) || (polynom2.Length == 1))
                resultPolynom = new int[Math.Max(polynom1.Length, polynom2.Length)];
            else
                resultPolynom = new int[Math.Max(polynom1.Length, polynom2.Length) + 1];

            try
            {
                for (int i = 0; i < polynom1.Length; i++)
                {
                    for (int j = 0; j < polynom2.Length; j++)
                    {
                        resultPolynom[i + j] += polynom1[i] * polynom2[j];
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Непредвиденная ошибка при умножении полиномов! Введите корректные значения!");
                Console.WriteLine(error.Message);
            }

            return resultPolynom;
        }

        static void Main(string[] args)
        {
            int[] polynom1;
            int[] polynom2;

            polynom1 = new int[] { 1, 2 };
            polynom2 = new int[] { 2, 4, 3, 4, 5, 6 };
            Console.WriteLine("Тест №1");
            foreach (int item in GetMultyplyPolynom(polynom1, polynom2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            polynom1 = new int[] { 3, 3, 4, 5, 6 };
            polynom2 = new int[] { 2, 4 };
            Console.WriteLine("Тест №2");
            foreach (int item in GetMultyplyPolynom(polynom1, polynom2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            polynom1 = new int[] { 3, 4, 0, 4, 5, 6 };
            polynom2 = new int[] { 2 };
            Console.WriteLine("Тест №3");
            foreach (int item in GetMultyplyPolynom(polynom1, polynom2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            polynom1 = new int[] { 3 };
            polynom2 = new int[] { 2 };
            Console.WriteLine("Тест №4");
            foreach (int item in GetMultyplyPolynom(polynom1, polynom2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            polynom1 = new int[] {  };
            polynom2 = new int[] { 2, 4, 6 };
            Console.WriteLine("Тест №5");
            foreach (int item in GetMultyplyPolynom(polynom1, polynom2))
            {
                Console.Write(item + " ");
            }

        }

        
    }
}
