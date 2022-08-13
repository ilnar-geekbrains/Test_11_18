using ArrayCopier.Extensions;
using ArrayCopier.Logic.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleClient
{
    public class Program
    {
        /// <summary>
        /// Точка входа в приложение
        /// </summary>
        public static void Main(string[] args)
        {
            // Регистрация зависимостей контекста ArrayCopier
            var services = new ServiceCollection();
            services.AddArrayCopierServices();

            // Получение сервиса контекста ArrayCopier
            var serviceProvider = services.BuildServiceProvider();
            var arrayCopierService = serviceProvider.GetRequiredService<IArrayCopierService>();

            // Ручное тестированиеметода копирования массивов сервиса arrayCopierService

            // Тестовые данные (1)
            // Входной и выходной массив имеют одинаковый тип и одинаковое кол-во элементов
            var intInArray_1 = new Int32[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var intOutArray_1 = new Int32[10];
            arrayCopierService.Copy<int>(intInArray_1, ref intOutArray_1);


            // Тестовые данные (2)
            // Выходной и выходной массив имеют одинаковые тип, но разное кол-во элементов
            var intInArray_2 = new Int32[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var intOutArray_2 = new Int32[3];
            try
            {
                arrayCopierService.Copy<int>(intInArray_2, ref intOutArray_2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // Тестовые данные (3)
            // Выходной и выходной массив имеют отличный тип, но одинаковое кол-во элементов
            var intInArray_3 = new string[10] { "s1", "s2", "s3", "s4", "s5", "s6", "s7", "s8", "s9", "s10" };
            var intOutArray_3 = new object[10];
            try
            {
                arrayCopierService.Copy<object>(intInArray_3, ref intOutArray_3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
