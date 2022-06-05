// Задача №2.  Написать программу для операции "произведение массивов". Сама операция определяется так,
// как будто элементы массива - это коэффициенты полинома. Соответственно, произведение массивов - должно
// дать новый массив, коэффициенты которого соответсвуют нужному полиному.
namespace Geekbrains
{
    class ArrayUtils
    {
        public static int[] Multiply(int[] a, int[] b)
        {
            if (a.Length == 0 || b.Length == 0)
                throw new ArgumentException();
            int[] result = new int[a.Length + b.Length - 1];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    result[i + j] += a[i] * b[j];
                }
            }
            return result;
        }
    }

    class TestUtils
    {
        public static bool AssertArraysEqual<T>(T[] a1, T[] a2)
        {
            if (ReferenceEquals(a1, a2))
                return true;

            if (a1 == null || a2 == null)
                return false;

            if (a1.Length != a2.Length)
                return false;

            var comparer = EqualityComparer<T>.Default;
            for (int i = 0; i < a1.Length; i++)
            {
                if (!comparer.Equals(a1[i], a2[i]))
                    return false;
            }
            return true;
        }
    }

    static class ArrayUtilsTest
    {
        static void Main(string[] args)
        {
            List<Func<bool>> tests = new List<Func<bool>>();
            tests.Add(() => BasicScenarioTest());
            tests.Add(() => TwoSingleElementArraysTest());
            tests.Add(() => ArraysOfDiffernetLengthTest());
            tests.Add(() => ZeroesTest());
            tests.Add(() => ShouldThrowExceptionOnEmptyArraysTest());

            for (int i = 0; i < tests.Count; i++)
            {
                Console.Write("Test " + (i + 1) + " - ");
                if (tests[i].Invoke())
                    Console.WriteLine("OK");
                else
                    Console.WriteLine("FAIL");
            }
        }

        static bool BasicScenarioTest()
        {
            int[] a = { -1, 1 };
            int[] b = { 2, 1 };
            int[] expected = { -2, 1, 1 };
            int[] actual = ArrayUtils.Multiply(a, b);
            return TestUtils.AssertArraysEqual(expected, actual);
        }

        static bool TwoSingleElementArraysTest()
        {
            int[] a = { 1 };
            int[] b = { 1 };
            int[] expected = { 1 };
            int[] actual = ArrayUtils.Multiply(a, b);
            return TestUtils.AssertArraysEqual(expected, actual);
        }

        static bool ArraysOfDiffernetLengthTest()
        {
            int[] a = { 5, 0, 1, 6 };
            int[] b = { 4, 9 };
            int[] expected = { 20, 45, 4, 33, 54 };
            int[] actual = ArrayUtils.Multiply(a, b);
            return TestUtils.AssertArraysEqual(expected, actual);
        }

        static bool ZeroesTest()
        {
            int[] a = { 0 };
            int[] b = { 0 };
            int[] expected = { 0 };
            int[] actual = ArrayUtils.Multiply(a, b);
            return TestUtils.AssertArraysEqual(expected, actual);
        }

        static bool ShouldThrowExceptionOnEmptyArraysTest()
        {
            int[] a = new int[0];
            int[] b = new int[0];
            try
            {
                int[] actual = ArrayUtils.Multiply(a, b);
                return false;
            }
            catch (ArgumentException)
            {
                return true;
            }
        }
    }
}