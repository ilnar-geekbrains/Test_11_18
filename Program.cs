// Задача №1. Написать программу для копирования массива

// Одномерные массивы
int[] myIntegers = { 10, 20, 30, 40, 50, 60 };

int[] myCopyIntegers = new int[myIntegers.Length];

Console.WriteLine("Исходный одномерный массив:");
PrintValues(myIntegers);

Console.WriteLine("Копия одномерного массива:");
Array.Copy(myIntegers, myCopyIntegers, myIntegers.Length);
PrintValues(myCopyIntegers);

Console.WriteLine("Другая копия одномерного массива:");
int[] anotherCopy = CopyValues(myIntegers);
PrintValues(myCopyIntegers);

int[] CopyValues(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}

void PrintValues(int[] array)
{
    foreach (int i in myIntegers)
    {
        Console.Write(" " + i.ToString());
    }
    Console.WriteLine();
}

// Двумерные массивы
int[,] my2DIntegers = { { 0, 1, 2, 3, 4 }, { 5, 6, 7, 8, 9 } };
int[,] my2DIntegersCopy;
CopyArrayGeneric(my2DIntegers, out my2DIntegersCopy);

Console.WriteLine("Исходный 2D массив:");
Print2DArray(my2DIntegers);
Console.WriteLine("2D массив копия:");
Print2DArray(my2DIntegersCopy);

string[,] myStrings = { { "a", "b", "c" }, { "A", "B", "C" } };
CopyArrayGeneric(myStrings, out string[,] myStringsCopy);

Console.WriteLine("Исходный 2D массив строк:");
Print2DArray(myStrings);
Console.WriteLine("2D копия массив строк:");
Print2DArray(myStringsCopy);

void CopyArrayGeneric<T>(T[,] arrayIn, out T[,] arrayOut)
{
    arrayOut = new T[arrayIn.GetLength(0), arrayIn.GetLength(1)];
    for (int i = 0; i < arrayIn.GetLength(0); i++)
    {
        for (int j = 0; j < arrayIn.GetLength(1); j++)
        {
            arrayOut[i, j] = arrayIn[i, j];
        }
    }
}

// Для разнотипных массивов
int[] myLengthsArray = new int[2] { 2, 5 };
Array my2DIntArray = Array.CreateInstance(typeof(int), myLengthsArray);
for (int i = 0; i < my2DIntArray.GetLength(0); i++)
    for (int j = 0; j < my2DIntArray.GetLength(1); j++)
        my2DIntArray.SetValue(my2DIntegers[i, j], i, j);

Array my2DObjArray = Array.CreateInstance(typeof(System.Object), myLengthsArray);

CopyAnyTypeArray(my2DIntArray, my2DObjArray);

Console.WriteLine("Исходный массив Int");
PrintArrayValues(my2DIntArray);
Console.WriteLine("Массив копия Int -> Object");
PrintArrayValues(my2DObjArray);


void CopyAnyTypeArray(Array arraySource, Array arrayReceiver)
{
    if (arraySource == null || arrayReceiver == null)
    {
        Console.WriteLine("Ошибка входных данных.");
        return;
    }
    if (arraySource.GetLength(0) != arrayReceiver.GetLength(0) || arraySource.GetLength(1) != arrayReceiver.GetLength(1))
    {
        Console.WriteLine("Не совпадает размерность массивов.");
        return;
    }

    Array myObjArray = Array.CreateInstance(typeof(System.Object), my2DIntArray.GetLength(0), my2DIntArray.GetLength(1));
    for (int i = 0; i < arraySource.GetLength(0); i++)
        for (int j = 0; j < arraySource.GetLength(1); j++)
            arrayReceiver.SetValue(my2DIntegers[i, j], i, j);
}


void Print2DArray<T>(T[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"\t{array[i, j]}");
        }
    }
    Console.WriteLine();
}

void PrintArrayValues(Array array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"\t{array.GetValue(i, j)}");
        }
    }
    Console.WriteLine();
}
