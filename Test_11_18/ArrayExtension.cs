namespace Test_11_18;

public static class ArrayExtension
{
    public static T[] MakeCopy<T>(this T[] array)
    {
        ArgumentNullException.ThrowIfNull(array);

        var copy = new T[array.Length];
        array.CopyTo(copy, 0);
        return copy;
    }
}
