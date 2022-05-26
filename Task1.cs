// See https://aka.ms/new-console-template for more information

 int[] multiplyArrays(int[] a, int[] b)
{
    int newArrayLenght = a.Length + b.Length - 1;
    // create array of nulls for multiplied polinom coefficients
    int[] result = new int[newArrayLenght];
    
    // Res(x) = Arr1(x)* Arr2(x) = sum(di) i=0..n+m
    // = (sum(ai*x^i)) * (sum(bj*x^j))  i = 0..n j=0..m
    // di = sum(ak*bl) i=k+l k=0..n l=0..m
    for (int k = 0; k < a.Length; k++)
    {
        for (int l = 0; l < b.Length; l++)
        {
            int i = k + l;
            result[i] += a[k] * b[l] ;
        }
    }


    return result;
}

bool areArraysEqual(int[] arr1, int[] arr2)
{
    if (arr1.Length != arr2.Length)
    {
        return false;
    }

    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] != arr2[i])
        {
            return false;
        }
    }

    return true;
}

Console.WriteLine("\nTest case  {0}", 1);
Console.WriteLine("(x-1)*(x+2)= x^2+x-2");
int[] arr1 = new int[2] { -1, 1};
int[] arr2 = new int[2] { 2, 1 };
int[] result = new int[3] { -2, 1, 1 };
int[] actual = multiplyArrays(arr1, arr2);
Console.WriteLine("\nMultiplied array: ");
for (int j = 0; j < actual.Length; j++)
{
    Console.Write(actual[j] + " ");
}
bool areEqueal = areArraysEqual(result, actual);
Console.WriteLine("\nAre equal: " + areEqueal);
if (areEqueal)
{
    Console.WriteLine("PASSED");
}
Console.WriteLine("----------------------------");

Console.WriteLine("\nTest case  {0}", 2);
Console.WriteLine("(x^2+x-1)*(x^3+2)= x^5+x^4-x^3+2*x^2+2x-2");
arr1 = new int[3] { -1, 1, 1 };
arr2 = new int[4] { 2, 0, 0, 1 };
result = new int[6] { -2, 2, 2, -1, 1, 1 };
actual = multiplyArrays(arr1, arr2);
Console.WriteLine("\nMultiplied array: ");
for (int j = 0; j < actual.Length; j++)
{
    Console.Write(actual[j] + " ");
}
areEqueal = areArraysEqual(result, actual);
Console.WriteLine("\nAre equal: " + areEqueal);
if (areEqueal)
{
    Console.WriteLine("PASSED");
}
Console.WriteLine("----------------------------");

Console.WriteLine("\nTest case  {0}", 3);
Console.WriteLine("(2x^2-3)*(7x^4+5)= 14x^6+10x^2-21x^4-15");
arr1 = new int[3] { -3, 0, 2 };
arr2 = new int[5] { 5, 0, 0, 0, 7 };
result = new int[7] { -15, 0, 10, 0, -21, 0, 14 };
actual = multiplyArrays(arr1, arr2);
Console.WriteLine("\nMultiplied array: ");
for (int j = 0; j < actual.Length; j++)
{
    Console.Write(actual[j] + " ");
}
areEqueal = areArraysEqual(result, actual);
Console.WriteLine("\nAre equal: " + areEqueal);
if (areEqueal)
{
    Console.WriteLine("PASSED");
}
Console.WriteLine("----------------------------");
