// Задача №1. Написать программу для копирования массива.
using System;

namespace Task1
{
    public class Program
    {
        public static T[] CoppyArray<T>(T[] _commingArray)
        {
            T[] _return = new T[_commingArray.Length];
            for (int i = 0; i < _commingArray.Length; i++)
            {
                _return[i] = _commingArray[i];
            }
            return _return;
        }

        private static void ShowArray<T>(T[] _commingArray, Action<string> methodToshow)
        {
            for (int i = 0; i < _commingArray.Length; i++)
            {
                methodToshow($"[{i + 1 }]: {_commingArray[i]} ");
            }
            methodToshow("\n");
        }
        public static int Main()
        {
            int[] exampleArray = { 5, 4, 7, 8, 6, 7 };
            int[] coppyedArray = CoppyArray(exampleArray);
            ShowArray(coppyedArray, System.Console.Write);
            return 0;
        }
    }
}