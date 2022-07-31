using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsTest
{
    public static class Tasks
    {
        public static T[] CopyArray<T>(T[] originalArray)
        {
            var arr = new T[originalArray.Length];

            for (var i = 0; i < originalArray.Length; i++)
            {
                arr[i] = originalArray[i];
            }

            return arr;
        }
    }
}
