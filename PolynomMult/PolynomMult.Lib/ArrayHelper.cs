namespace PolynomMult.Lib
{
    public class ArrayHelper
    {
        /// <summary>
        /// Выполняет операцию произведения двух массивов double[] по правилу произведения полиномов
        /// </summary>        
        public static double[] PolynomMult(double[] p1, double[] p2)
        {
            int p1_Length = p1.Length;
            int p_Length2 = p2.Length;                            

            var res = new double[p1_Length + p_Length2 - 1];

            for (int i = 0; i < p1_Length; i++)
            {
                for (int j = 0; j < p_Length2; j++)
                {
                    res[i + j] += p1[i] * p2[j];
                }
            }

            return res;
        }

        /// <summary>
        /// В консоли запрашивает строку и преобразовывает её в массив double[] 
        /// </summary>
        /// <param name="message">Сообщение, выводимое в консоль</param>
        /// <returns>Массив double[]</returns>
        public static double[] RequestDoubleArrayFromConsole(string message)
        {
            do
            {
                bool isError = false;

                Console.Write(message);
                string userInput = Console.ReadLine() ?? "";
                if (string.IsNullOrEmpty(userInput)) continue;
                var userInputStringArray = userInput.Split(new char[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
                
                double[] res = new double[userInputStringArray.Length];

                for (int i = 0; i < userInputStringArray.Length; i++)
                {
                    if (!double.TryParse(userInputStringArray[i], out res[i]))
                    {
                        Console.WriteLine("Ошибка ввода!");
                        isError = true;
                    }
                }

                if(!isError)
                    return res;
            }
            while (true);
        }


        /// <summary>
        /// Выводит полином на консоль
        /// </summary>
        public static void PrintPolynomToConsole(double[] p)
        {
            Console.Write("f(x) = ");
            for (int i = 0; i < p.Length; i++)
            {
                if (i != 0) Console.Write(" + ");

                if (p[i] < 0)
                    Console.Write($"({p[i]})*x^{i}");
                else
                    Console.Write($"{p[i]}*x^{i}");
            }
        }
    }
}
