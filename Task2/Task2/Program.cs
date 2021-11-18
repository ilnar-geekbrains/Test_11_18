using System;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeArray array1 = new PalindromeArray(new int[]{-1,1});
            PalindromeArray array2 = new PalindromeArray(new int[]{2,1});
            PalindromeArray rezults = array1 * array2;
            System.Console.WriteLine(array1);
            System.Console.WriteLine(array2);
            System.Console.WriteLine(rezults);
        }
    }
}
