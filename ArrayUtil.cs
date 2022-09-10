namespace Arrays;

public static class ArrayUtil
{
    public static bool Copy(int[] source, int[] destination)
    {
        if (source.Length != destination.Length)
        {
            return false;
        }

        return true;
    }
}