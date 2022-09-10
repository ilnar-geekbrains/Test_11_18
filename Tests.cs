namespace Arrays;

public static class Tests
{
    public static void Length_of_arrays_must_be_same(int[] source, int[] destination)
    {
        Console.WriteLine(
            $"Тест проверки одинаковой длины массива. Входные данные: source.Length {source.Length} | destination.Length {destination.Length}");

        bool result = ArrayUtil.Copy(source, destination);
        PrintResult(result);
    }

    public static void Input_data_must_be_initialized(int[] source, int[] destination)
    {
        Console.WriteLine(
            $"Тест проверки на инициализацию массивов. Входные данные: source is initialized - {source != null} | destination is initialized - {destination != null}");

        bool result = ArrayUtil.Copy(source, destination);
        PrintResult(result);
    }

    public static void Arrays_must_have_the_same_contents(int[] firstArray, int[] secondArray)
    {
        Console.WriteLine(
            $"Тест проверки на идентичность массивов. Входные данные: first array - {string.Join(',', firstArray)} | second array  - {string.Join(',', secondArray)}");

        bool result = true;
        if (firstArray.Length != secondArray.Length)
        {
            result = false;
        }
        else
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    result = false;
                    break;
                }
            }
        }

        PrintResult(result);
    }

    private static void PrintResult(bool result)
    {
        Console.WriteLine(result ? $"ПРОЙДЕН" : $"ПРОВАЛЕН");
        Console.WriteLine("===== Конец теста =====");
    }
}