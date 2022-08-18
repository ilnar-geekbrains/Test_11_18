using System;

namespace GeekBrainsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var element = new double[] { -1, 3 };
            var clone  = element.DeepClone();
        }
    }
}
