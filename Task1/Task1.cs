// Task 1
// Write a programm which create a copy of an array

int[] CopyArray(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}

void ShowArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

// Test
//
// Array is an linked type, so we can't just use '==' operator.
// That's why I use a buildin method 'Enumerable.SequenceEqual' for test.

int[] testArray = new int[5]{1, 2, 3, 2, 1};

// Lets check that sequences are equal

if (Enumerable.SequenceEqual(testArray, CopyArray(testArray)))
{
    Console.WriteLine("Test completed.");
}
else
{
    Console.WriteLine("Test failed.");
}

// Check that copy isn't a link to original array

int[] test = CopyArray(testArray);
test[1] = 10;

Console.WriteLine("Copy, after element changing:");
ShowArray(test);
Console.WriteLine();
Console.WriteLine("Original array:");
ShowArray(testArray);
