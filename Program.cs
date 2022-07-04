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

bool Test (int[] firstArray, int[] secondArray, int[] thirdArray)
{
    int[] result = GetCoeffsEquation(firstArray, secondArray);
    bool valid = true;
    for (int i = 0; i < thirdArray.Length; i++)
    {
        valid = valid & (thirdArray[i] == result[i]);
    }
    return valid;
}

int[] arrayA = {-1, 1};
int[] arrayB = {2, 1};
int[] arrayC = {-2, 1, 1}; // (x - 1) * (x + 2) = x^2 + x - 2
Console.WriteLine(Test(arrayA, arrayB, arrayC));

int[] arrayD = {0};
int[] arrayE = {0, 0}; // (x - 1) * 0 = 0 * x - 0
Console.WriteLine(Test(arrayA, arrayD, arrayE));

int[] arrayF = {1, 2, 3, 4, 5};
int[] arrayG = {2, 1, 8, 7};
int[] arrayH = {2, 5, 16, 34, 52, 58, 68, 35};
/*
(5x^4 + 4x^3 + 3x^2 + 2x + 1) * (7x^3 + 8x^2 + x + 2) = 35x^7 + 64x^6 + 58x^5 + 52x^4 + 34x^3 + 16x^2 + 5x+ 2
*/
Console.WriteLine(Test(arrayF, arrayG, arrayH));

int[] arrayI = {-1, -1};
int[] arrayJ = {-2, -2};
int[] arrayK = {2, 4, 2}; // (-x - 1) * (-2x - 2) = 2x^2 + 4x + 2
Console.WriteLine(Test(arrayI, arrayJ, arrayK));