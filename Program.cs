using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Задача №1. Написать программу для копирования массива.");
            int[] arrayOriginal = new int[] { 1, 2, 3, 4, 6 };
            CopyArray(arrayOriginal);
        }

        static int[] CopyArray(int[] array)
        {            
            int n = array.Length;
            int[] arrayCopy = new int[n];
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    arrayCopy[i] = array[i];
                    Console.WriteLine(array[i] + " arrayOriginal");
                    Console.WriteLine(arrayCopy[i] + " arrayCopy");
                }
            }
            else { Console.WriteLine("arrayOriginal = null"); }
            return arrayCopy;
        }
    }
}
