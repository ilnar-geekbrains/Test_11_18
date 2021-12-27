using System;

// Решение первой задачи
class CopyArrayTest
{

    static int[] CopyArr(int[] array1, int[] array2, int num_items)
    {

        for (int i = 0; i < num_items; i++)
        {
            try
            {
                array2[i] = array1[i];
            }
            catch
            {
                System.Console.WriteLine("Ошибка при заполнении массива!");
            }
 
        }

       
        return array2;
    }


    static void Main()
    {

        int num_items = 10;

        int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] array2 = new int[num_items];

        CopyArr(array1, array2, array1.Length);

        // выводим массив
        for (int i = 0; i < array2.Length; i++)
        {
            System.Console.WriteLine(array2[i]);
        }

        // запсукаем тесты
        tests();

    }

    static void tests()
    {
        int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] array2 = new int[10];

        CopyArr(array1, array2, array1.Length);

        if (array1.Length == array2.Length)
        {
            System.Console.WriteLine("Тест пройден");
        }
        else
        {
            System.Console.WriteLine("Тест провален");
        }

        if (array1[0] == 1 && array2[0] == 1)
        {
            System.Console.WriteLine("Тест пройден");
        }
        else
        {
            System.Console.WriteLine("Тест провален");
        }

        if (array1[1] == 2 && array2[1] == 2)
        {
            System.Console.WriteLine("Тест пройден");
        }
        else
        {
            System.Console.WriteLine("Тест провален");
        }

        if (array1[9] == 10 && array2[9] == 10)
        {
            System.Console.WriteLine("Тест пройден");
        }
        else
        {
            System.Console.WriteLine("Тест провален");
        }

    }
}