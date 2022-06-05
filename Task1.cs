// Задача №1. Написать программу для копирования массива.
namespace Geekbrains
{
    class ArrayUtils
    {
        public static void Copy<T>(T[] from, T[] to)
        {
            if (from == null || to == null || from.Length != to.Length)
                throw new ArgumentException();

            for (int i = 0; i < from.Length; i++)
                to[i] = from[i];
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
            tests.Add(() => BasicScenarioIntegerTest());
            tests.Add(() => BasicScenarioStringTest());
            tests.Add(() => ShouldWorkCorrectlyOnEmptyArray());
            tests.Add(() => ShouldWorkCorrectlyOnSingleElementArray());
            tests.Add(() => ShouldThrowExceptionOnNullFromArray());
            tests.Add(() => ShouldThrowExceptionOnNullTargetArray());
            tests.Add(() => ShouldThrowExceptionOnDifferentArraysLength());

            for (int i = 0; i < tests.Count; i++)
            {
                Console.Write("Test " + (i + 1) + " - ");
                if (tests[i].Invoke())
                    Console.WriteLine("OK");
                else
                    Console.WriteLine("FAIL");
            }
        }

        static bool BasicScenarioIntegerTest()
        {
            int[] from = { 1, 2, 3 };
            int[] to = new int[3];
            ArrayUtils.Copy(from, to);
            return TestUtils.AssertArraysEqual(from, to);
        }

        static bool BasicScenarioStringTest()
        {
            string[] from = { "foo", "bar", "baz" };
            string[] to = new string[3];
            ArrayUtils.Copy(from, to);
            return TestUtils.AssertArraysEqual(from, to);
        }

        static bool ShouldWorkCorrectlyOnEmptyArray()
        {
            int[] from = new int[0];
            int[] to = new int[0];
            ArrayUtils.Copy(from, to);
            return TestUtils.AssertArraysEqual(from, to);
        }

        static bool ShouldWorkCorrectlyOnSingleElementArray()
        {
            int[] from = { 5 };
            int[] to = new int[1];
            ArrayUtils.Copy(from, to);
            return TestUtils.AssertArraysEqual(from, to);
        }

        static bool ShouldThrowExceptionOnNullFromArray()
        {
            int[]? from = null;
            int[] to = new int[3];
            try
            {
                ArrayUtils.Copy(from, to);
                return false;
            }
            catch (ArgumentException)
            {
                return true;
            }
        }

        static bool ShouldThrowExceptionOnNullTargetArray()
        {
            int[] from = { 1, 2, 3 };
            int[]? to = null;
            try
            {
                ArrayUtils.Copy(from, to);
                return false;
            }
            catch (ArgumentException)
            {
                return true;
            }
        }

        static bool ShouldThrowExceptionOnDifferentArraysLength()
        {
            int[] from = { 1, 2, 3 };
            int[] to = new int[4];
            try
            {
                ArrayUtils.Copy(from, to);
                return false;
            }
            catch (ArgumentException)
            {
                return true;
            }
        }
    }
}