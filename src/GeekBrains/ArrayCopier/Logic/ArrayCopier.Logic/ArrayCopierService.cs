using ArrayCopier.Logic.Interfaces;

namespace ArrayCopier.Logic
{
    /// <summary>
    /// Сервис копирования массивов
    /// </summary>
    public class ArrayCopierService : IArrayCopierService
    {
        /// <summary>
        /// Копирование диапазона элементов массива
        /// Производит мягкое копирование по значению
        /// </summary>
        /// <param name="sourceArray">Массив, содержащий данные, которые требуется скопировать</param>
        /// <param name="destinationArray">Массив, в который будут копироваться данные массива sourceArray</param>
        public void Copy<T>(T[] sourceArray, ref T[] destinationArray)
        {
            #region Валидация входных параметров

            // Проверка входного массива sourceArray на существование в памяти
            if (sourceArray == null)
            {
                throw new ArgumentNullException(nameof(sourceArray));
            }

            // Проверка на соответствие типов элементов входного и выходного массивов
            if (sourceArray.GetType().GetElementType() != destinationArray.GetType().GetElementType())
            {
                throw new InvalidCastException();
            }

            // Проверка на равность размерностей входного и выходного массива
            if (sourceArray.Length != destinationArray.Length)
            {
                throw new Exception("The dimensions of the input and output arrays are not equal");
            }

            #endregion

            // Поверхностное копирование элементов входного массива в выходной массив
            for (Int32 i = 0; i < sourceArray.Length; i++)
            {
                destinationArray.SetValue(sourceArray.GetValue(i), i);
            }
        }
    }
}
