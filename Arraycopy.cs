using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraycopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создаем список
            List<int> CopyList(List<int> a)
            {
                //возвращаем значение списка
                return new List<int>(a);
            }

            bool Compare(List<int> arr1, List<int> arr2)
            {
                //сравниваем количество элементов массивов
                if (arr1.Count != arr2.Count)
                {
                    return false;
                }
                //сравниваем значения элементов массивов
                for (int i = 0; i < Math.Min(arr1.Count, arr2.Count); i += 1)
                {
                    if (arr1[i] != arr2[i])
                    {
                        return false;
                    }
                }

                return true;
            }
            //Тест #1
            if (Compare(CopyList(new List<int> { 1 }), new List<int> { 1 }))
            {
                Console.WriteLine("Верно");
            }
            else
            {
                Console.WriteLine("Неверно");
            }
            //Тест #2

            if (Compare(CopyList(new List<int>()), new List<int>()))
            {
                Console.WriteLine("Верно");
            }
            else
            {
                Console.WriteLine("Неверно");
            }
            //Тест #3

            if (Compare(CopyList(new List<int> { 1, 2, 3, 4, 5 }), new List<int> { 1 }))
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
