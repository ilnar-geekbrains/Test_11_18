// Task 2
// Write a program for the operation "product of arrays".
// The operation itself is defined as if the array elements are the coefficients of a polynom.
// So, the product of arrays should give a new array whose coefficients correspond to the desired polynom.

int[] PolinomialArrayProd(int[] p1, int[] p2)
{
    int[] result = new int[p1.Length + p2.Length - 1];
    for (int i = 0; i < p1.Length; ++i)
        for (int j = 0; j < p2.Length; ++j)
            result[i + j] += p1[i] * p2[j];
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

// Tests

int[] pol1 = new int[2] { -1, 1 };
int[] pol2 = new int[2] { 2, 1 };
int[] pol3 = new int[3] { 2, 1, 3 };

// (-1+x)*(2+x) = -2+x+x^2 
PrintArray(PolinomialArrayProd(pol1, pol2));
Console.WriteLine();

// (-1+x)*(2+x+3x^2) = -2+x-2x^2+3x 
PrintArray(PolinomialArrayProd(pol1, pol3));
Console.WriteLine();

// (2+x+3x^2)*(2+x) = 4+4x+7x^2+3x^3
PrintArray(PolinomialArrayProd(pol3, pol2));
Console.WriteLine();