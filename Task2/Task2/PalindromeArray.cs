using System;

namespace Task2
{
    public class  PalindromeArray
    {
        private int[] palindromeCoefficients { get; set; }
        public int Length => palindromeCoefficients.Length;
        public PalindromeArray(int[] polindromCoefficients)
        {
            this.palindromeCoefficients = polindromCoefficients;
        }
        public int this[int index]
        {
            get
            {
                return palindromeCoefficients[index];
            }
        }
        public static PalindromeArray operator *(PalindromeArray palindromeArray1, PalindromeArray palindromeArray2)
        {
            int[] _return = new int[palindromeArray1.Length + palindromeArray2.Length - 1];
            for (int i = 0; i < palindromeArray1.Length; i++)
            {
                for (int j = 0; j < palindromeArray2.Length; j++)
                {
                    _return[i+j] += palindromeArray1[i] * palindromeArray2[j];
                }
            }
            return new PalindromeArray(_return);
        }
        public override string ToString()
        {
            string _return = "[ ";
            for (int i = 0; i < palindromeCoefficients.Length; i++)
            {
                 _return += palindromeCoefficients[i];
                 if(i != palindromeCoefficients.Length - 1)
                 {
                     _return += ", ";
                 }
            } 
            _return += "]";
            return _return;
        }
    } 
}