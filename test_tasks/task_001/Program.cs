// Написать программу для копирования массива

int[] copyArray(int[] initArray)
{
    // Объявляем массив для создания копии такого же размера что и исходный массив
    int[] resultArray = new int[initArray.GetLength(0)];
    // Для всех элементов массива результатов присваиваем 
    // соответствующее значение исходного массива
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        resultArray[i] = initArray[i];
    }
    // Функция возвращает результатом работы копию исходного массива
    return resultArray;
}

// Тесты

if ("1 2 3" == string.Join(" ", copyArray(new int[]{1, 2, 3})))
{
    System.Console.WriteLine("Тест пройден");
}
else
{
    System.Console.WriteLine("Тест провален");
}

if ("1 2 3 4" != string.Join(" ", copyArray(new int[]{1, 2, 3})))
{
    System.Console.WriteLine("Тест пройден");
}
else
{
    System.Console.WriteLine("Тест провален");
}

if ("0 -2 7 0" == string.Join(" ", copyArray(new int[]{0, -2, 7, 0})))
{
    System.Console.WriteLine("Тест пройден");
}
else
{
    System.Console.WriteLine("Тест провален");
}