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
    // Функция возвращает резултатом работы копию исходного массива
    return resultArray;
}

System.Console.WriteLine(string.Join(" ", copyArray(new int[]{1, 2, 3})));