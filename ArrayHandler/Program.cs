// Задача 1. Написать программу для копирования массива.
// Пример. Реализовано только для одномерных массивов типа int

// Запуск тестов
GetCopyArrayTests();
EqualsTests();

/// <summary> Метод копирования массивов int </summary>
int[]? GetCopyArray(int[]? srcArray)
{
    if (srcArray == null) return null;
    if (srcArray.Length == 0) return Array.Empty<int>();

    var copy = new int[srcArray.Length];
    for (int i = 0; i < srcArray.Length; i++)
    {
        copy[i] = srcArray[i];
    }
    return copy;
}

/// <summary> Метод сравления массивов </summary>
bool Equals(int[]? array1, int[]? array2)
{
    if (array1 == null && array2 == null) return true;
    if (array1 == null || array2 == null) return false;
    if (array1.Length == 0 && array2.Length == 0) return true;
    if (array1.Length != array2.Length) return false;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] != array2[i]) return false;
    }
    return true;
}

/// <summary> Тесты  для метода GetCopyArray </summary>
void GetCopyArrayTests()
{
    // тесты метода GetCopyArray
    int[] test1 = new int[] { 1, 2, 3 };
    if (Equals(GetCopyArray(test1), test1))
    {
        Console.WriteLine("Тест пройден");
    }
    else
    {
        Console.WriteLine("Тест провален");
    }

    int[]? test2 = null;
    if (Equals(GetCopyArray(test2), test2))
    {
        Console.WriteLine("Тест пройден");
    }
    else
    {
        Console.WriteLine("Тест провален");
    }

    int[] test3 = Array.Empty<int>();
    if (Equals(GetCopyArray(test3), test3))
    {
        Console.WriteLine("Тест пройден");
    }
    else
    {
        Console.WriteLine("Тест провален");
    }
}

/// <summary> Тесты  для метода Equals </summary>
void EqualsTests()
{
    // тесты метода Equals
    int[]? arrayNullable = null;
    int[] arrayEmpty = Array.Empty<int>();
    int[] array3 = new int[] { 1, 2, 3 };
    int[] array5 = new int[] { 1, 2, 3, 4, 5 };

    if (Equals(arrayNullable, arrayNullable))
    {
        Console.WriteLine("Тест пройден");
    }
    else
    {
        Console.WriteLine("Тест провален");
    }

    if (!Equals(arrayNullable, array3))
    {
        Console.WriteLine("Тест пройден");
    }
    else
    {
        Console.WriteLine("Тест провален");
    }

    if (Equals(arrayEmpty, arrayEmpty))
    {
        Console.WriteLine("Тест пройден");
    }
    else
    {
        Console.WriteLine("Тест провален");
    }

    if (!Equals(array5, array3))
    {
        Console.WriteLine("Тест пройден");
    }
    else
    {
        Console.WriteLine("Тест провален");
    }

    if (Equals(array5, array5))
    {
        Console.WriteLine("Тест пройден");
    }
    else
    {
        Console.WriteLine("Тест провален");
    }
}