using System;
using System.Collections;
using System.Collections.Generic;

namespace Test
{

    

    internal class Program
    {
        static Random rand = new Random();

        static void print(List<int> a)
        {
            foreach(int i in a)
                Console.Write($"{i} ");
            Console.WriteLine("\n");
        }
        static void print(List<int> a, List<int> b)
        {
            Console.Write("First array: ");
            foreach (int i in a)
                Console.Write($"{i} ");
            Console.WriteLine("\n");
            Console.Write("Second array: ");
            foreach (int i in b)
                Console.Write($"{i} ");
            Console.WriteLine("\n");
        }

        static List<int> PolynomMultiply(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < a.Count + b.Count - 1; i++) // Создание элементов
                result.Add(0);

            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < b.Count; j++)
                {
                    result[i + j] += a[i] * b[j];
                }
            }


            return result;
        }

        static void Main(string[] args)
        {
            const int maxRand = 10;
            int sizeA = 3;
            int sizeB = 2;
            List<int> a = new List<int>();
            List<int> b = new List<int>();


            for(int i = 0; i < (sizeA < sizeB ? sizeB:sizeA); i++) // Заполнение массивов рандом элементами
            {
                if (i < sizeA)
                    a.Add(rand.Next(-maxRand, maxRand));
                if (i < sizeB)
                    b.Add(rand.Next(-maxRand, maxRand));
            }
            print(a, b);

            List<int> result = PolynomMultiply(a, b);

            Console.Write("Result array: ");
            print(result);

            Console.ReadKey();
        }
    }
}
