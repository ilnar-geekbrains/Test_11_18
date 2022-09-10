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
}