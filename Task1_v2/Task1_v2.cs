// Task 1
// Write a programm which create a copy of an array

using System;

namespace Task1
{

    class ArrayCopyer
    {
        // This class describes a method to copy an accepted array.

        internal T[] CopyArray<T>(T[] array)
        {
            T[] arrayCopy = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayCopy[i] = array[i];
            }
            return arrayCopy;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            // Method to print array in console
            void ShowArray<T>(T[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }

            string isLink = "Is a link to the same object";
            string notLink = "Not a link to the same object";

            ArrayCopyer copyer = new ArrayCopyer();
            // Class ArrayCopyer described higher


            // Tests
            // We'll define some arrays with different tipes
            // then create their copies and check:
            // 1. their elements are the same
            // 2. copy isn't a link to initial array objeckt (we'll use '==')

            int[] testArray1 = new int[5] { 1, 2, 3, 2, 1 };
            double[] testArray2 = new double[5] { 1.1, 2.2, 3.3, 2.2, 1.1 };
            string[] testArray3 = new string[5] { "1", "2", "3", "2", "1" };
            Object[] testArray4 = new Object[4] { 1, "2", 3.3, '2' };

            int[] test1 = copyer.CopyArray(testArray1);
            double[] test2 = copyer.CopyArray(testArray2);
            string[] test3 = copyer.CopyArray(testArray3);
            Object[] test4 = copyer.CopyArray(testArray4);

            Console.Write("Initial array is: ");
            ShowArray(testArray1);
            Console.Write("Copy of array is: ");
            ShowArray(test1);
            Console.WriteLine(testArray1 == test1 ? isLink : notLink);

            Console.Write("Initial array is: ");
            ShowArray(testArray2);
            Console.Write("Copy of array is: ");
            ShowArray(test2);
            Console.WriteLine(testArray2 == test2 ? isLink : notLink);

            Console.Write("Initial array is: ");
            ShowArray(testArray3);
            Console.Write("Copy of array is: ");
            ShowArray(test3);
            Console.WriteLine(testArray3 == test3 ? isLink : notLink);

            Console.Write("Initial array is: ");
            ShowArray(testArray4);
            Console.Write("Copy of array is: ");
            ShowArray(test4);
            Console.WriteLine(testArray4 == test4 ? isLink : notLink);
        }
    }
}
