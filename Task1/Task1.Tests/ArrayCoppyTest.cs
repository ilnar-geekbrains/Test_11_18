using System;
using Xunit;
using Task1.Tests;

namespace Task1.Tests
{
    public class ArrayCoppyTest
    {
        [Fact]
        public void CoppyArray_StringArray()
        {
            string[] arrayToSend = {"H","e","l","l","o"};
            string[] results = Program.CoppyArray(arrayToSend);
            arrayToSend[3] = "Z";
            string[] ethelon = {"H","e","l","l","o"};
            bool rezult = false;
            for(int i = 0; i < arrayToSend.Length; i++)
            {
                rezult = (results[i] == ethelon[i]);
                if(!rezult)
                {
                    break;
                }
            }
            Assert.True(rezult,"Not correct coppy of string");
        }
        [Fact]
        public void CoppyArray_IntArray()
        {
            int[] arrayToSend = {1,5,7,8,6,7,8,4,6};
            int[] results = Program.CoppyArray(arrayToSend);
            arrayToSend[3] = 88;
            int[] ethelon = {1,5,7,8,6,7,8,4,6};
            bool rezult = false;
            for(int i = 0; i < arrayToSend.Length; i++)
            {
                rezult = (results[i] == ethelon[i]);
                if(!rezult)
                {
                    break;
                }
            }
            Assert.True(rezult,"Not correct coppy of int");
        }
        [Fact]
        public void CoppyArray_DoubleArray()
        {
            double[] arrayToSend = {1.4,5.7,7.5,8.6,6.7,7.9,8.9,4.7,6.3};
            double[] results = Program.CoppyArray(arrayToSend);
            arrayToSend[3] = 88;
            double[] ethelon = {1.4,5.7,7.5,8.6,6.7,7.9,8.9,4.7,6.3};
            bool rezult = false;
            for(int i = 0; i < arrayToSend.Length; i++)
            {
                rezult = (results[i] == ethelon[i]);
                if(!rezult)
                {
                    break;
                }
            }
            Assert.True(rezult,"Not correct coppy of double");
        }
    }
}
