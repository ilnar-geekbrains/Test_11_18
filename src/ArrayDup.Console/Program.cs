using ArrayDup.Library;
using System;
using System.Collections.Generic;

namespace ArrayDup.Console
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var source = GenerateRandom.GeneratorRandomArray.Generate();
            DisplayCollection(source);
            var arrayDup = new ArrayDup<int>();
            var dest = arrayDup.Copy(source);
            DisplayCollection(dest);
        }

        private static void DisplayCollection(IEnumerable<int> data)
        {
            System.Console.Write("Source collection is: ");
            foreach (var element in data)
            {
                System.Console.Write(element + " ");
            }

            System.Console.WriteLine();
        }
    }
}
