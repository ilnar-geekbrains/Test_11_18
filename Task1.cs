// See https://aka.ms/new-console-template for more information


int[] copyArray(int[] arr)
{
    int lenght = arr.Length;
    int[] copy = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        copy[i] = arr[i];
    }

    return copy;
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

int[] generateArray(int lenght)
{
    int[] arr = new int[lenght];
    int maxValue = Int32.MaxValue;
    int minValue = Int32.MinValue;
    Random randNum = new Random();

    for (int i = 0; i < lenght; i++)
    {
        arr[i] = randNum.Next(minValue, maxValue);
    }

    return arr;
}

void main()
{

}


// 5 test cases
int testCasesNumber = 5;
for(int i = 0; i < testCasesNumber; i++)
{
    Random rnd = new Random();
    int randomLenght = rnd.Next(1, 10);
    Console.WriteLine("\nTest case  {0}", i);
    Console.WriteLine("Array lenght: {0}", randomLenght);
    int[] generatedArray = generateArray(randomLenght);
    Console.WriteLine("\nGenerated array: ");
    for (int j = 0; j < randomLenght; j++)
    {
        Console.Write(generatedArray[j] + " ");
    }
    int[] copy = copyArray(generatedArray);
    Console.WriteLine("\nCopied array: ");
    for (int j = 0; j < randomLenght; j++)
    {
        Console.Write(copy[j] + " ");
    }
    bool areEqueal = areArraysEqual(generatedArray, copy);
    Console.WriteLine("\nAre equal: " + areEqueal);
    Console.WriteLine("----------------------------");
}
