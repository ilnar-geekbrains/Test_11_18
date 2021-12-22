using System;
using System.Collections.Generic;

namespace MainProj
{
    class Program
    {
        static int[] Multiply(int[] a, int[] b)
        {
            int[] resultArray = new int[a.Length + b.Length - 1];

            for (int leftIndex = a.Length - 1; leftIndex > -1; leftIndex--)
            {
                for (int rightIndex = b.Length - 1; rightIndex > -1; rightIndex--)
                {
                    resultArray[leftIndex + rightIndex] += a[leftIndex] * b[rightIndex];
                }
            }

            return resultArray;
        }

        static void Main(string[] args)
        {
            List<int> leftArray = new List<int>();
            List<int> rightArray = new List<int>();
            bool ArrayInput(List<int> array)
            {
                int enteredNumber = 0;
                while (Int32.TryParse(Console.ReadLine(), out enteredNumber))
                {
                    array.Add(enteredNumber);
                }

                array.Reverse();
                if (array.Count == 0)
                    array.Add(0);

                return false;
            }

            Console.WriteLine("Enter left array (nan for stop)");
            while (ArrayInput(leftArray)) ;
            Console.WriteLine("Enter right array (nan for stop)");
            while (ArrayInput(rightArray)) ;

            Console.WriteLine("Result: ");
            int[] result = null;
            try
            {
                result = Multiply(leftArray.ToArray(), rightArray.ToArray());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message +"\n Any Key....");
                Console.ReadKey();
                Environment.Exit(1);
            }

            for (int i = result.Length - 1; i > -1; i--)
            {
                Console.Write(result[i].ToString() + ", ");
            }
            
        }
    }
}
