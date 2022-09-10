namespace Arrays;

public static class ArrayUtil
{
    public static bool Copy(int[] source, int[] destination)
    {
        if (source == null || destination == null)
            return false;

        if (source.Length != destination.Length)
            return false;

        return true;
    }
}