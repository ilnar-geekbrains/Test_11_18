using System;

// Решение второй задачи
class MultiArrayTest
{

    static int[] MultiArr(int[] array1, int[] array2, int[] array3)
    {

        for (int i = 0; i < array1.Length; i++)
        {
            for (int n = 0; n < array2.Length; n++)
            {

                try
                {
                    array3[i + n] += array1[i] * array2[n];
                }
                catch
                {
                    System.Console.WriteLine("Ошибка при заполнении массива!");
                }
            }

        }


        return array3;
    }


    static void Main()
    {

        int[] array1 = { -1, 1 };
        int[] array2 = { 2, 1 };

        int num_items = array1.Length + array2.Length - 1;
        int[] array3 = new int[num_items];

        MultiArr(array1, array2, array3);

        // выводим массив
        for (int i = 0; i < array3.Length; i++)
        {
            System.Console.WriteLine(array3[i]);
        }

        // запсукаем тесты
        tests();

    }

    static void tests()
    {
        int[] array1 = { -1, 1 };
        int[] array2 = { 2, 1 };

        int num_items = array1.Length + array2.Length - 1;
        int[] array3 = new int[num_items];

        MultiArr(array1, array2, array3);

        if (array3[0] == -2 && array3[1] == 1 && array3[2] == 1)
        {
            System.Console.WriteLine("Тест пройден");
        }
        else
        {
            System.Console.WriteLine("Тест провален");
        }

        int[] array4 = { -3, 5 };
        int[] array5 = { 2, -7 };

        int num_items2 = array4.Length + array5.Length - 1;
        int[] array6 = new int[num_items2];

        MultiArr(array4, array5, array6);

        if (array6[0] == -6 && array6[1] == 31 && array6[2] == -35)
        {
            System.Console.WriteLine("Тест пройден");
        }
        else
        {
            System.Console.WriteLine("Тест провален");
        }

        int[] array7 = { -1, 5 };
        int[] array8 = { 2, 4 };

        int num_items3 = array7.Length + array8.Length - 1;
        int[] array9 = new int[num_items3];

        MultiArr(array7, array8, array9);

        if (array9[0] == -2 && array9[1] == 6 && array9[2] == 20)
        {
            System.Console.WriteLine("Тест пройден");
        }
        else
        {
            System.Console.WriteLine("Тест провален");
        }

    }
}