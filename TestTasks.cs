namespace TestTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1 : Array copy");

            #region Task 1

            int[] randomArray = Array.CreateRandomArray(5);

            Console.WriteLine("");
            Console.WriteLine("First test case:", "");
            Array.CheckEquality(randomArray, Array.Copy(randomArray));

            Console.WriteLine("");
            Console.WriteLine("Second test case:");
            Array.CheckEquality(randomArray, new int[5] { 1, 2, 3, 5, 7 });

            Console.WriteLine("");
            Console.WriteLine("Third test case:");
            Array.CheckEquality(randomArray, new int[4] { 1, 2, 3, 5 });

            Console.WriteLine("");

            #endregion

            Console.WriteLine("Task 2 : Multiplying arrays");

            #region Task 2

            Console.WriteLine("");
            Console.WriteLine("First test case:", "");
            Array.MultiplyArrays(new int[2] { -1, 1 }, new int[2] { 2, 1 });

            Console.WriteLine("");
            Console.WriteLine("Second test case:", "");
            Array.MultiplyArrays(new int[2] { -4, 1 }, new int[3] { 2, 1, 3 });

            Console.WriteLine("");
            Console.WriteLine("Third test case:", "");
            Array.MultiplyArrays(new int[3] { -5, 1, 7 }, new int[3] { 2, 1, 7 });

            #endregion
        }

    }

    public static class Array
    {
        /// <summary>
        /// Копирование массива
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static T[] Copy<T>(this T[] array)
        {
            T[] copyArray = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                copyArray[i] = array[i];
            }
            return copyArray;
        }


        /// <summary>
        /// Провека на равенство массивов
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="firstArray"></param>
        /// <param name="secondArray"></param>
        public static void CheckEquality<T>(T[] firstArray, T[] secondArray)
        {
            PrintArrays(firstArray, secondArray);

            bool isEqual = true;

            if (ReferenceEquals(firstArray, secondArray))
                isEqual = true;


            if (firstArray.Length != secondArray.Length)
                isEqual = false;
            else
            {
                EqualityComparer<T> comparer = EqualityComparer<T>.Default;

                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (!comparer.Equals(firstArray[i], secondArray[i]))
                        isEqual = false;
                }
            }

            PrintComparisonResult(isEqual);
        }

        /// <summary>
        /// Генерация массива со случайными значениями
        /// </summary>
        /// <param name="capacity">Размер массива</param>
        /// <returns></returns>
        public static int[] CreateRandomArray(int capacity)
        {
            int[] newArray = new int[capacity];
            Random random = new Random();
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = random.Next(15);
            }
            return newArray;
        }

        /// <summary>
        /// Произведение 2 массивов
        /// </summary>
        /// <param name="firstArray"></param>
        /// <param name="secondArray"></param>
        public static void MultiplyArrays(int[] firstArray, int[] secondArray)
        {
            PrintArrays(firstArray, secondArray);

            int[] result = new int[firstArray.Length + secondArray.Length - 1];

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    result[i + j] += firstArray[i] * secondArray[j];
                }
            }

            PrintMultiplyResult(result);
        }

        /// <summary>
        /// Вывод на консоль входных массивов
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="firstArray"></param>
        /// <param name="secondArray"></param>
        private static void PrintArrays<T>(T[] firstArray, T[] secondArray)
        {
            Console.WriteLine("First array :[{0}]", string.Join(", ", firstArray));
            Console.WriteLine("Second array :[{0}]", string.Join(", ", secondArray));
        }

        /// <summary>
        /// Вывод на консоль результата проверки массивов
        /// </summary>
        /// <param name="isEqual">Результат проверки</param>
        private static void PrintComparisonResult(bool isEqual)
        {
            Console.WriteLine(isEqual ? "Arrays are equal" : "Arrays are not equal");
        }

        /// <summary>
        /// Вывод результат произведения массивов
        /// </summary>
        /// <param name="multipliedArray">Полученный массив</param>
        private static void PrintMultiplyResult(int[] multipliedArray)
        {
            Console.WriteLine("Multiplied array :[{0}]", string.Join(", ", multipliedArray));
        }
    }
}