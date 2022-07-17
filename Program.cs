using System;
using System.Text;

class Program 

{
    // Функция перемножения полиномов
    public static double[] mult(double []A, double []B) 
    {
        int m = A.Length;
        int n = B.Length;

        var result = new double[m + n - 1];


        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++) 
            {

                result[i + j] += A[i] * B[j];

            }

        }

        return result;
    }
    
    // Функция для записи полиномов
    public static void PolynomPrint(double []polynom, double n)
    {

        for (int i = 0; i < n; i++) {

            Console.Write(polynom[i]);

            if (i != 0) {

                Console.Write("x^" + i);

            }

            if (i != n - 1) {

                Console.Write(" + ");

            }

        }

    }

    // Функция для сравнения массивов
    public static bool masEqual<A>(A[] predictPol, A[] resultPol)
    {
        return predictPol.SequenceEqual(resultPol);
    }

    // Тесты
    public static void Test()
    {
        bool isOK;
        double[] test1PolLeft = { -1, 1 };
        double[] test1PolRight = { 2, 1 };
        double[] test1Result = { -2, 1, 1 };

        isOK = masEqual(test1Result, mult(test1PolLeft, test1PolRight));
        MessageTest(isOK);
         
        // Ошибочный тест
        double[] test2PolLeft = { 5, 6, 1, 2 };
        double[] test2PolRight = { 1, 4, 5 };
        double[] test2Result = { 1, 26, 40, 36, 13, 0 }; 

        isOK = masEqual(test2Result, mult(test2PolLeft, test2PolRight));
        MessageTest(isOK);

        double[] test3PolLeft = { 1, 2};
        double[] test3PolRight = {-3, -7, 1 };
        double[] test3Result = {-3, -13, -13, 2 };

        isOK = masEqual(test3Result, mult(test3PolLeft, test3PolRight));
        MessageTest(isOK);
    }

    // Функция для записи прохождения тестов
    public static void MessageTest(bool isOK)
    {
        if (isOK)
        {
            Console.WriteLine("Всё верно");
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Тестовые варианты: ");
        Test();
        Console.WriteLine("\t");


        Console.WriteLine("Введите количество элементов первого полинома: ");
        int elementsCountFirst = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите элементы первого полинома: ");
        double[] A = new double[elementsCountFirst];
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }
        double m = A.Length;
        Console.WriteLine("Первый полином: ");
        PolynomPrint(A, m);
        Console.WriteLine("\t");

        Console.WriteLine("Введите количество элементов второго полинома: ");
        int elementsCountSecond = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите элементы второго полинома: ");
        double []B = new double[elementsCountSecond];
        for (int i = 0; i < B.Length; i++)
        {
            B[i] = int.Parse(Console.ReadLine());
        }
        double n = B.Length;
        Console.WriteLine("Второй полином: ");
        PolynomPrint(B, n);
        Console.WriteLine("\t");

        double[] result = mult(A, B);
        Console.WriteLine("Результат: ");
        PolynomPrint(result, m + n - 1);

    }

}
