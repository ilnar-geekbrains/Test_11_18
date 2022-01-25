using System;

namespace Test_11_18
{
    class CopyUtils
    {
        // простой пример копирования целочисленных массивов
        public static void CopyArrays(int[] source, int[] dest)
        {
            int lengthSource = source.Length;
            int lengthDest = dest.Length;

            for (int i = 0; i < Math.Min(lengthSource, lengthDest); i++)
            {
                dest[i] = source[i];
            }

            return;
        }

        // простой пример - создание копии массива целых чисел
        public static int[] CopyIntArray(int[] source)
        {
            int length = source.Length;

            if (length == 0)
                return null;

            int[] copy = new int[length];

            for (int i = 0; i < length; i++)
            {
                copy[i] = source[i];
            }

            return copy;
        }

        // более сложный пример - создание копии массива для простых (не ссылочных) типов
        // с помощью универсальных методов
        public static T[] CopyArray<T>(T[] source) where T: unmanaged
        {
            if (source == null)
                return null;

            int length = source.Length;

            if (length == 0)
                return null;

            T[] copy = new T[length];

            for (int i = 0; i < length; i++)
            {
                copy[i] = source[i];
            }

            return copy;
        }

        // более сложный пример
        // создание копии массива для классов, реализующих интерфейс ICloneable
        // с том, чтобы элементы копии были не ссылкой на элементы первоначального массива,
        // а новыми объектами
        public static T[] CopyCloneArray<T>(T[] source) where T : ICloneable
        {
            if (source == null)
                return null;

            int length = source.Length;

            if (length == 0)
                return null;

            T[] copy = new T[length];

            for (int i = 0; i < length; i++)
            {
                copy[i] = (T)source[i].Clone();
            }

            return copy;
        }

        // умножение полиномов
        public static int[] MultPoly(int[] poly1, int[] poly2)
        {
            int length1 = poly1.Length;
            int length2 = poly2.Length;

            if (length1 == 0 || length2 == 0)
                return null;

            int multLength = length1 + length2 - 1;

            int[] res = new int[multLength];

            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < length2; j++)
                    res[i + j] += poly1[i] * poly2[j];
            }
            return res;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums2 = new int[12] { 1, 2, 3, 5, 15, -5, 6432, 2, 3, 1975, 98, -5 };
            int[] nums1 = new int[12];

            // 1
            CopyUtils.CopyArrays(nums2, nums1);

            bool test = true;

            for (int i = 0; i < 12; i++)
            {
                if (nums1[i] != nums2[i])
                {
                    test = false;
                    break;
                }
            }

            if (!test)
                Console.WriteLine("Error - CopyArrays");
            else
                Console.WriteLine("Passed - CopyArrays");

            // 2
            int[] res = CopyUtils.CopyIntArray(nums2);

            test = true;

            for (int i = 0; i < 12; i++)
            {
                if (res[i] != nums2[i])
                {
                    test = false;
                    break;
                }
            }

            if (!test)
                Console.WriteLine("Error - CopyIntArray");
            else
                Console.WriteLine("Passed - CopyIntArray");

            // 3
            res = CopyUtils.CopyArray<int>(nums2);

            test = true;

            for (int i = 0; i < 12; i++)
            {
                if (res[i] != nums2[i])
                {
                    test = false;
                    break;
                }
            }

            if (!test)
                Console.WriteLine("Error - CopyArray<int>");
            else
                Console.WriteLine("Passed - CopyArray<int>");

            // 4
            string[] strs1 = new string[] { "Yesterday", "All", "my", "troubles", "seemed", "so", "far", "away" };

            string[] sres = CopyUtils.CopyCloneArray<string>(strs1);

            test = true;

            for (int i = 0; i < strs1.Length; i++)
            {
                if (String.Compare(sres[i], strs1[i]) != 0)
                {
                    test = false;
                    break;
                }
            }

            if (!test)
                Console.WriteLine("Error - CopyCloneArray<string>");
            else
                Console.WriteLine("Passed  - CopyCloneArray<string>");

            // 5 
            Person[] p1 = new Person[] { new Person("Fred", 35, new Company("Microsoft")), new Person("Mike", 45, new Company("Oracle")) };

            Person[] p2 = CopyUtils.CopyCloneArray<Person>(p1);

            test = true;

            for (int i = 0; i < p1.Length; i++)
            {
                if (!p1[i].Equals(p2[i]))
                {
                    test = false;
                    break;
                }
            }

            if (!test)
                Console.WriteLine("Error - CopyCloneArray<Person>");
            else
                Console.WriteLine("Passed  - CopyCloneArray<Person>");


            // polynoms
            int[] poly1 = new int[2] { -1, 1 };
            int[] poly2 = new int[3] { 2, 1, 1 };

            int[] r = CopyUtils.MultPoly(poly1, poly2);

            int[] result = new int[4] { -2, 1, 0, 1 };

            test = true;

            for (int i = 0; i < 4; i++)
            {
                if (r[i] != result[i])
                {
                    test = false;
                    break;
                }
            }
            if (!test)
                Console.WriteLine("Error - MultPoly");
            else
                Console.WriteLine("Passed  - MultPoly");

        }

    }

    class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Company Work { get; set; }
        public Person(string name, int age, Company company)
        {
            Name = name;
            Age = age;
            Work = company;
        }
        public object Clone() => new Person(Name, Age, new Company(Work.Name));

        // упрощенный вариант сравнения 
        public bool Equals(Person p1)
        {
            if (p1 == null)
                return false;
            else if (p1.Age == this.Age && String.Compare(p1.Name, this.Name) == 0
                                && String.Compare(p1.Work.Name, this.Work.Name) == 0 )
                return true;
            else
                return false;
        }
    }
    class Company
    {
        public string Name { get; set; }
        public Company(string name) => Name = name;
    }


}
