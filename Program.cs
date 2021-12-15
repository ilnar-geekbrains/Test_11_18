using System;
using System.Collections.Generic;

namespace Test_11_18
{
  class Program
  {
    static void Main(string[] args)
    {
      Random random = new Random();

      Console.WriteLine("Задача 1. Копирвоание массивов");
      int[] array = CreateRandomizeArray(5, random);
      int[] copy = array.Copy();

      bool referenceTest = copy != array;
      Console.WriteLine($"Тест 1 - {referenceTest}");
      bool elementsTest = copy[0] == array[0];
      Console.WriteLine($"Тест 2 - {elementsTest}");

      Console.WriteLine("\nЗадача 2. Умножение массивов");
      int[] a = { -1, 1 };
      int[] b = { 2, 1 };
      var resultArray = MultiplicationArrays(a, b);

      bool firstValueTest = resultArray[0] == -2;
      Console.WriteLine($"Тест 1 - {firstValueTest}");
      bool secondValueTest = resultArray[1] == 1;
      Console.WriteLine($"Тест 2 - {secondValueTest}");
      bool thirdValueTest = resultArray[2] == 1;
      Console.WriteLine($"Тест 3 - {thirdValueTest}");

      Console.WriteLine("Резальтат умножения: ");
      foreach (var item in resultArray)
      {
        Console.Write(item + " ");
      }
    }

    static int[] CreateRandomizeArray(int capacity, Random randomizer)
    {
      int[] newArray = new int[capacity];
      for (int i = 0; i < newArray.Length; i++)
      {
        newArray[i] = randomizer.Next(10);
      }
      return newArray;
    }

    static int[] MultiplicationArrays(int[] a, int[] b)
    {
      int[] result = new int[a.Length + b.Length - 1];
      for (int i = 0; i < a.Length; i++)
      {
        for (int j = 0; j < b.Length; j++)
        {
          result[i + j] += a[i] * b[j];
        }
      }
      return result;
    }
  }
}
