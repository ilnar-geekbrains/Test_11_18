namespace GB_test;

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

    //Тесты функции для "произведения массивов"
    public static void TestCopyArray()
    {
        bool isOK = true;

        int[] testIntArray1 = { 1, 2, 4, 7, 8 };
        int[] resultIntArray1 = { 1, 4, 7, 8 };

        //Специально написан тест с неправильными условиями
        isOK = IsArrayEqual(resultIntArray1, CopyArray(testIntArray1));
        SetMessage(isOK);

        int[] testIntArray2 = { 1, };

        isOK = IsArrayEqual(testIntArray2, CopyArray(testIntArray2));
        SetMessage(isOK);

        string[] testStringArray1 = { "Tyrannosaurus", "Deinonychus", "Velociraptor" };

        isOK = IsArrayEqual(testStringArray1, CopyArray(testStringArray1));
        SetMessage(isOK);

        string[] testStringArray2 = { "a" };

        isOK = IsArrayEqual(testStringArray2, CopyArray(testStringArray2));
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

        float[] test1L = { -3, 0, 2 };
        float[] test1R = { 2, 1 };
        float[] test1Result = { -6, -3, 4, 2 };

        isOK = IsArrayEqual(test1Result, ArrDot(test1L, test1R));
        SetMessage(isOK);

        float[] test2L = { -1, 1 };
        float[] test2R = { 2, 1 };
        float[] test2Result = { -2, 1, 1 };

        isOK = IsArrayEqual(test2Result, ArrDot(test2L, test2R));
        SetMessage(isOK);

        float[] test3L = { -1, 1 };
        float[] test3R = { 1, 1, 1 };
        float[] test3Result = { -1, 0, 0, 1 };

        isOK = IsArrayEqual(test3Result, ArrDot(test3L, test3R));
        SetMessage(isOK);

        float[] test4L = { 1 };
        float[] test4R = { -1 };
        float[] test4Result = { -1 };

        isOK = IsArrayEqual(test4Result, ArrDot(test4L, test4R));
        SetMessage(isOK);

    }

    //Функция вывода об успешном прохождении теста
    public static void SetMessage(bool isOK)
    {
        if (isOK) Console.WriteLine("Тест пройден");

        else Console.WriteLine("Тест не пройден");
    }

    // Точка входа в программу
    static void Main()
    {
        TestCopyArray(); //Запустить тесты функции для копирования массива
        TestArrDot(); //Запустить тесты функции для "произведения массивов"
    }
}
