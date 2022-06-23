using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestG
{
    class Array
    {
        public static void Copy<T>(T[] from, T[] to)
        {
            for (int i = 0; i < from.Length; i++)
            {
                to[i] = from[i];
            }
        }
        public static int[] Multiply(int[] a, int[] b)
        {
            int[] _result = new int[a.Length + b.Length - 1];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    _result[i + j] += a[i] * b[j];
                }
            }
            return _result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<bool> tests = new List<bool>();
            tests.Add(CopyIntegerTestArray());
            tests.Add(CopyStringTestArray());
            tests.Add(ArrayMultiplyTestOne());
            tests.Add(ArrayMultiplyTestTwo());

            for (int i = 0; i < tests.Count; i++)
            {
                if (tests[i])
                {
                    Console.WriteLine("GOOD");
                }
                else
                {
                    Console.WriteLine("FAIL");
                }
            }
            Console.ReadLine();
        }
        //Тестер
        public static bool ArrayTest<T>(T[] a1, T[] a2)
        {
            var _arrayComp = EqualityComparer<T>.Default;
           

            if (a1 == null | a2 == null)
            {
                return false;
            }

            if (a1.Length != a2.Length)
            {
                return false;
            }

            if (ReferenceEquals(a1, a2))
            {
                return true;
            }

            for (int i = 0; i < a1.Length; i++)
            {
                if (!_arrayComp.Equals(a1[i], a2[i]))
                {
                    return false;
                }
            }
            return true;
        }
        //Сценарии для тестов
        static bool CopyIntegerTestArray()
        {
            int _indexMax = new Random().Next(0, 100);
            int[] from = new int[_indexMax];
            int[] to = new int[_indexMax];
            for (int i = 0; i < _indexMax; i++)
            {
                from[i] = new Random().Next(0, 100);
            }
            Array.Copy(from, to);
            return ArrayTest(from, to);
        }

        static bool CopyStringTestArray()
        {
            string[] from = { "Bike", "Cucumber", "Skyline", "Sunshine", "Live", "Dead" };
            string[] to = new string[from.Length];
            Array.Copy(from, to);
            return ArrayTest(from, to);
        }
        static bool ArrayMultiplyTestOne()
        {
            int[] a = { -1, 1 };
            int[] b = { 2, 1 };
            int[] _answer = { -2, 1, 1 };
            int[] _real = Array.Multiply(a, b);
            return ArrayTest(_answer, _real);
        }

        static bool ArrayMultiplyTestTwo()
        {
            int[] a = { 1 };
            int[] b = { 1 };
            int[] _answer = { 1 };
            int[] _real = Array.Multiply(a, b);
            return ArrayTest(_answer, _real);
        }

    }
}

