// Задача №1. Написать программу для копирования массива.

int[] array = new int[5];
int[] arrayCopy = new int[array.Length];

void FillArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void CopyArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
}


FillArrayRandom(array);
CopyArray(array);
Console.WriteLine("Random array:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Array copy:");
PrintArray(arrayCopy);
Console.WriteLine();
