using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создаем список
            List<long> Composition(List<long> a, List<long> b)
            {
                //создаем новый список и заполняем его
                var ans = new List<long>(new long[a.Count + b.Count - 1]);
                for (var i = 0; i < a.Count; i++)
                {
                    for (var j = 0; j < b.Count; j++)
                    {
                        ans[i + j] += a[i] * b[j];//произведение двух исходных списков
                    }
                }

                return ans;
            }
            //сравниваем два списка
            bool Compare(List<long> arr1, List<long> arr2)
            {
                if (arr1.Count != arr2.Count)
                {
                    return false;
                }

                for (var i = 0; i < Math.Min(arr1.Count, arr2.Count); i += 1)
                {
                    if (arr1[i] != arr2[i])
                    {
                        return false;
                    }
                }

                return true;
            }

            //Тест #1
            if (Compare(Composition(new List<long> { 1, 0, 0 }, new List<long> { 1, 2, 3 }), new List<long> { 1, 2, 3, 0, 0 }))
            {
                Console.WriteLine("Верно");
            }
            else
            {
                Console.WriteLine("Неверно");
            }
            //Тест #2

            if (Compare(Composition(new List<long> { 1 }, new List<long> { 1 }), new List<long> { 1 }))
            {
                Console.WriteLine("Верно");
            }
            else
            {
                Console.WriteLine("Неверно");
            }
            //Тест #3

            if (Compare(Composition(new List<long> { 1, 0, 0 }, new List<long> { 1, 2, 3 }), new List<long> { 1, 2, 3 }))
            {
                Console.WriteLine("Неверно");
            }
            else
            {
                Console.WriteLine("Верно");
            }
        }
    }
}
