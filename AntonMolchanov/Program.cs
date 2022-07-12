﻿// Задание 1. Написать программу для копирования массива.
/*
int [] CreateRandomArray(int size)
{
    int [] Array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(1, 11);
    }
    return Array;
}

void PrintArray(int [] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write(Arr[i] + " ");
    }
    Console.WriteLine();
}

int [] CopyArray(int [] Arra)
{
    int [] NewArray = new int [Arra.Length];
    for (int i = 0; i < Arra.Length; i++)
    {
        NewArray[i] = Arra[i];
    }
    return NewArray;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] OriginalArray = CreateRandomArray(size);
int [] Dublicat = CopyArray(OriginalArray);
PrintArray(OriginalArray);
PrintArray(Dublicat);
*/

// Задача 2. Написать программу для операции "произведение массивов". 
// Сама операция определяется так, как будто элементы массива - это коэффициенты полинома. 
// Соответственно, произведение массивов - должно дать новый массив, 
// коэффициенты которого соответсвуют нужному полиному.

// Например, возьмем полином (x - 1) и полином (x + 2). 
// Их можно представить в виде массивов [-1, 1] и [2, 1] соответственно. 
// Индекс элемента в массиве соответствует степени x при этом коээфициенте, 
// т.е. полином (x - 1) можно переписать как (-1 * x^0 + 1 * x^1), 
// таким образом соответсвующий этому полиному массив будет иметь вид [-1, 1].

// По указанному правилу произведение массивов [-1, 1] и [2, 1] должно быть равно [-2, 1, 1], 
// т.к. (x - 1) * (x + 2) = (x^2 + x^1 - 2).

int[] PolynomToArray(string poly)// метод, который перобразовывает полином, записанный в string, в массив.
{
    int DegreeIndex = poly.IndexOf("^") + 1; // находим индекс старшей степени полинома.
    int size = Convert.ToInt32(poly[DegreeIndex] + 1);   // нашли размер нашего массива. 
    int[] Array = new int[size];
    int i = 0;
    // тут надо придумать, как распарсить строку и затем сформировать массив из коэффициентов.
    while(poly.Length > 4)
    {
        int ind = poly.IndexOf("*"); // находим индекс знака умножения
        Array[i] = Convert.ToInt32(poly.Substring(0, ind)); //делаем срез строки до индекса знака умножения.
        int plusIndex = poly.IndexOf("+");
        poly = poly.Remove(0, plusIndex+1);

    }
    return Array;
}

void PrintArray(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write(Arr[i] + " ");
    }
    Console.WriteLine();
}

int[] ArrayMultiplication(int[] Arra1, int[] Arra2) // метод для перемножения двух массивов.
{
    int size = Arra1.Length + Arra2.Length - 1;
    int[] ResultArray = new int[size];
    for (int i = 0; i < Arra1.Length; i++)
    {
        for (int j = 0; j < Arra2.Length; j++)
        {
            ResultArray[i + j] += Arra1[i] * Arra2[j];
        }
    }
    return ResultArray;
}

void FromArrayToString(int[] Array) // метод из массива возвращаетполином в строчном виде.
{
    string polynom = string.Empty;
    for (int i = 0; i < Array.Length; i++)
    {
        if (i == Array.Length - 1) polynom = $"{Array[i]}*x^{i}" + polynom;
        else polynom = $"+{Array[i]}*x^{i}" + polynom;
    }
    Console.WriteLine(polynom);
}


int[] Polynom1 = {-1, 1};
int[] Polynom2 = {2, 1};

int[] NewArray = ArrayMultiplication(Polynom1, Polynom2);
PrintArray(NewArray);
FromArrayToString(NewArray);


    