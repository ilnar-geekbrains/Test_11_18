// Написать программу для копирования массива.

/// <summary>
/// Обёртка для стандартного метода класса Array (самая быстрая реализация)
/// </summary>
/// <param name="array">Числовой массив</param>
/// <returns>Скопированный числовой массив</returns>
int[] CopyArray(int[] array)
{
    int[] resultArray = new int[array.Length];
    array.CopyTo(resultArray, 0);
    return resultArray;
}

/// <summary>
/// Собственная реализация метода копирования массива
/// </summary>
/// <param name="array">Числовой массив</param>
/// <returns>Скопированный числовой массив</returns>
int[] CustomCopyArray(int[] array)
{
    int[] resultArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        resultArray[i] = array[i];
    }
    return resultArray;
}

/// <summary>
/// Метод для проверки равенства двух массивов
/// </summary>
/// <param name="array">Два числовых массива</param>
/// <returns>Значение bool</returns>
bool isArraysEqual(int[] arr1, int[] arr2)
{
    if (arr1.Length != arr2.Length)
    {
        return false;
    }

    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] != arr2[i])
        {
            return false;
        }
    }

    return true;
}

// Тесты
int[] array = new int[] { 1, 2, 3 };
int[] copyArray = CopyArray(array);
int[] customCopyArray = CustomCopyArray(array);

if (array == copyArray)
{
    System.Console.WriteLine("Тест пройден");
}
else
{
    System.Console.WriteLine("Тест провален");
}

if (array == customCopyArray)
{
    System.Console.WriteLine("Тест пройден");
}
else
{
    System.Console.WriteLine("Тест провален");
}

if (copyArray == customCopyArray)
{
    System.Console.WriteLine("Тест пройден");
}
else
{
    System.Console.WriteLine("Тест провален");
}