namespace Arrays;

public static class Tests
{
    public static void Length_of_arrays_must_be_same(int[] source, int[] destination)
    {
        Console.WriteLine(
            $"Тест проверки одинаковой длины массива. Входные данные: source.Length {source.Length} | destination.Length {destination.Length}");

        bool result = ArrayUtil.Copy(source, destination);
        Console.WriteLine(result ? $"ПРОЙДЕН" : $"ПРОВАЛЕН");
        Console.WriteLine("===== Конец теста =====");
    }

    public static void Input_data_must_be_initialized(int[] source, int[] destination)
    {
        Console.WriteLine(
            $"Тест проверки на инициализацию массивов. Входные данные: source is initialized - {source != null} | destination is initialized - {destination != null}");

        bool result = ArrayUtil.Copy(source, destination);
        Console.WriteLine(result ? $"ПРОЙДЕН" : $"ПРОВАЛЕН");
        Console.WriteLine("===== Конец теста =====");
    }
}