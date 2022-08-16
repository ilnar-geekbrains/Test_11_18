using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pln1 = new int[] { 2, 1};
            int[] pln2 = new int[] { 2, 4, 3 };
            foreach(int item in NewPolynom(pln1, pln2))
            {
                Console.WriteLine(item);
            }
            
        }

        public static int[] NewPolynom(int[] pln1, int[] pln2)
        {
            if ((pln1 == null) || (pln2 == null))
                return new int[0];
            int[] resPln = new int[Math.Max(pln1.Length, pln2.Length) + 1];
            for (int i = 0; i < pln1.Length; i++)
            {
                for (int j = 0; j < pln2.Length; j++)
                {
                    resPln[i+j] += pln1[i] * pln2[j];
                }    
            }
            return resPln;
        }
    }
}
