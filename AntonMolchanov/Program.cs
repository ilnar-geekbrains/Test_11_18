// Задание 1. Написать программу для копирования массива.
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

