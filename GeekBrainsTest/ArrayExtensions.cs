using System;
using System.Linq;

namespace GeekBrainsTest
{
    public static class ArrayExtensions
    {

        public static T[] DeepClone<T>(this T[] value)
        {
            if (value is null)
                return null;

            return value.Select(s => s).ToArray();
        }

        public static bool IsEqualsByValue<T>(this T[] source, T[] compareToItem)
            where T : struct
        {
            if (source == null && compareToItem == null)
                return true;

            if (source == null || compareToItem == null)
                return false;

            if (source.Length != compareToItem.Length)
                return false;

            for (int i = 0; i < source.Length; i++)
            {
                if (!Equals(source[i], compareToItem[i]))
                    return false;
            }

            return true;
        }
    }
}
