using PolynomMult.Lib;

namespace PolynomMult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Консольное приложение позволяет выполнить операцию \"произведение массивов\"," +
                " определяемую так, что элементы массива являются коэффициентами соответствующего полинома." +
                " Результатом операции является новый массив, коэффициенты которого соответствуют нужному полиному.");

            do
            {
                Console.WriteLine("-------------------------");
                var p1 = ArrayHelper.RequestDoubleArrayFromConsole("Введите коэффициенты полинома 1: ");
                var p2 = ArrayHelper.RequestDoubleArrayFromConsole("Введите коэффициенты полинома 2: ");

                var res = ArrayHelper.PolynomMult(p1, p2);
                ArrayHelper.PrintPolynomToConsole(res);

                Console.Write("\nДля продолжения работы нажмите любую клавишу. q - для выхода: ");
            }
            while (Console.ReadLine() != "q");

                        
        }        
    }
}