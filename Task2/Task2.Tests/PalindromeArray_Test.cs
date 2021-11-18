using System;
using Xunit;

namespace Task2.Tests
{
    public class PalindromeArray_Test
    {
        [Fact]
        public void PalindromeArray_Test_Multy_Two_Coef()
        {
            PalindromeArray array1 = new PalindromeArray(new int[]{-1,1});
            PalindromeArray array2 = new PalindromeArray(new int[]{2,1});
            PalindromeArray rezults = array1 * array2;
            int[] ethelon = {-2,1,1}; 
            bool rezult = false;
            for(int i = 0; i < ethelon.Length; i++)
            {
                rezult = (rezults[i] == ethelon[i]);
                if(!rezult)
                {
                    break;
                }
            }
            Assert.True(rezult,"");
        }
        [Fact]
        public void PalindromeArray_Test_Multy_Fourth_Coef()
        {
            PalindromeArray array1 = new PalindromeArray(new int[]{7,1,2,3});
            PalindromeArray array2 = new PalindromeArray(new int[]{-5,2,1});
            PalindromeArray rezults = array1 * array2;
            int[] ethelon = {-35,9,-1,-10,8,3}; 
            bool rezult = false;
            for(int i = 0; i < ethelon.Length; i++)
            {
                rezult = (rezults[i] == ethelon[i]);
                if(!rezult)
                {
                    break;
                }
            }
            Assert.True(rezult,"");
        }
    }
}
