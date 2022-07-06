// Написать программу для копирования массива

int[] copyArray(int[] initArray)
{
    int[] resultArray = new int[initArray.GetLength(0)];
    for (int i = 0; i < initArray.GetLength(0); i++)
    {
        resultArray[i] = initArray[i];
    }
    return resultArray;
}
