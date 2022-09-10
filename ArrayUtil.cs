namespace Arrays;

public enum ErrorCode
{
    Empty,
    NotInitializedInputData,
    DifferentArrayLengths
}

public static class ArrayUtil
{
    public static ErrorCode Copy(int[] source, int[] destination)
    {
        if (source == null || destination == null)
            return ErrorCode.NotInitializedInputData;

        if (source.Length != destination.Length)
            return ErrorCode.DifferentArrayLengths;

        for (int i = 0; i < source.Length; i++)
        {
            destination[i] = source[i];
        }

        return ErrorCode.Empty;
    }
}