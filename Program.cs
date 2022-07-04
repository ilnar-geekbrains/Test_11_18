int[] GetCoeffsEquation (int[] firstArray, int[] secondArray)
{
    int[] result = new int[firstArray.Length + secondArray.Length - 1];

    for (int i = 0; i < firstArray.Length; i++)
    {
        for (int j = 0; j < secondArray.Length; j++)
        {
            int index = i + j;
            result[index] += firstArray[i] * secondArray[j];
        }
    }
    return result;
}