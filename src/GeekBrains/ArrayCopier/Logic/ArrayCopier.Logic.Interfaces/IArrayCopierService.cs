namespace ArrayCopier.Logic.Interfaces
{
    /// <summary>
    /// Сервис копирования массивов
    /// </summary>
    public interface IArrayCopierService
    {
        /// <summary>
        /// Копирование диапазона элементов массива
        /// Производит мягкое копирование по значению
        /// </summary>
        /// <param name="sourceArray">Массив, содержащий данные, которые требуется скопировать</param>
        /// <param name="destinationArray">Массив, в который будут копироваться данные массива sourceArray</param>
        void Copy<T>(T[] sourceArray, ref T[] destinationArray);
    }
}
