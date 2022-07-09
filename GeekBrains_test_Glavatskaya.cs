namespace test_Glavatskaya;

public class Program
{
    //Функция для копирования массива
    public static T[] CopyArray<T>(T[] source) 
    {
        T[] newArray = new T[source.Length];
        Array.Copy(source, newArray, source.Length);
        return newArray;
    }

    //Функция для сравнения двух массивов
    public static bool IsArrayEqual<T>(T[] predictValue, T[] resultValue)
    {
        return predictValue.SequenceEqual(resultValue);
    }

    //Тесты "копирования массивов"
    public static void TestCopyArray()
    {
        bool isOK;

        int[] testIntArray1 = { 50, 30, 4, 6, 9 };
        int[] resultIntArray1 = { 50, 30, 4, 6, 9 };

        isOK = IsArrayEqual(resultIntArray1, CopyArray(testIntArray1));
        SetMessage(isOK);
    }

    //Функция для "произведения массивов"
    public static float[] ArrDot (float[] firstArray, float[] secondArray)
    {
        float[] result = new float[firstArray.Length + secondArray.Length - 1];
        Array.Fill(result, 0, 0, result.Length);

        for (var i = 0; i < firstArray.Length; i++)
            for (var j = 0; j < secondArray.Length; j++)
                result[i + j] += firstArray[i] * secondArray[j];

        return result;
    }

    //Тесты функции для "произведения массивов"
    public static void TestArrDot()
    {
        bool isOK;

        float[] test1L = { 2, 4, 6 };
        float[] test1R = { 3, 9, 11 };
        float[] test1Result = { 6, 30, 76, 98,66 };

        isOK = IsArrayEqual(test1Result, ArrDot(test1L, test1R));
        SetMessage(isOK);

        float[] test2L = { -2, 6};
        float[] test2R = { -3 };
        float[] test2Result = { 6, -18};

        isOK = IsArrayEqual(test2Result, ArrDot(test2L, test2R));
        SetMessage(isOK);

        //Специальный "провальный" тест

        float[] test3L = { 5, 2, -1};
        float[] test3R = { -4, 8 };
        float[] test3Result = { 12, 32, 20, -8};

        isOK = IsArrayEqual(test3Result, ArrDot(test3L, test3R));
        SetMessage(isOK);
    }

    //Функция вывода об успешном прохождении теста
    public static void SetMessage(bool isOK)
    {
        if (isOK) Console.WriteLine("Успешно");

        else Console.WriteLine("Провалено");
    }

    // Точка входа в программу
    static void Main()
    {
        TestCopyArray(); //Запустить тесты функции для копирования массива
        TestArrDot(); //Запустить тесты функции для "произведения массивов"
    }
}
