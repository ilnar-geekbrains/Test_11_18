//1
T[] CopyArray<T>(T[] array)
{
    if (array is null)
    {
        throw new ArgumentNullException();
    }

    var result = new T[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }

    return result;
}

//Tests
//Positive
Console.WriteLine("Copy Array");
Console.WriteLine("1 Test");

var arrayInt = new[] { -1, 1 };
var expectedInt = new[] { -1, 1 };
var actualInt = CopyArray(arrayInt);

if (expectedInt.SequenceEqual(actualInt) && !ReferenceEquals(expectedInt,arrayInt))
{
    Console.WriteLine("Test passed.");
}
else
{
    Console.WriteLine("The test failed elements are not equal.");
}

Console.WriteLine("2 Test");
var arrayString = new[] { "123", "123" };
var expectedString = new[] { "123", "123" };
var actualString = CopyArray(arrayString);

if (expectedString.SequenceEqual(actualString) && !ReferenceEquals(expectedString,arrayString))
{
    Console.WriteLine("Test passed.");
}
else
{
    Console.WriteLine("The test failed elements are not equal.");
}

Console.WriteLine("3 Test");
var arrayChar = Array.Empty<char>();
var expectedChar = Array.Empty<char>();
var actualChar = CopyArray(arrayChar);

if (expectedChar.SequenceEqual(actualChar) && ReferenceEquals(expectedChar, arrayChar))
{
    Console.WriteLine("Test passed.");
}
else
{
    Console.WriteLine("The test failed elements are not equal.");
}

Console.WriteLine("4 Test");
//Negative
try
{
    CopyArray<int>(null!);

    Console.WriteLine("The test failed");
}
catch (ArgumentNullException)
{
    Console.WriteLine("Test passed.");
}
catch (Exception)
{
    Console.WriteLine("The test failed because was throw other exception");
}

//2
int[] MultiplyPolynomials(int[] left, int[] right)
{
    if (left is null || right is null)
    {
        throw new ArgumentNullException();
    }

    if (left.Length == 0 || right.Length == 0)
    {
        throw new ArgumentException();
    }

    var lengthResult = left.Length + right.Length - 1;
    var result = new int[lengthResult];
    for (var i = 0; i < left.Length; i++)
    {
        for (var j = 0; j < right.Length; j++)
        {
            var degree = j + i;
            result[degree] += left[i] * right[j];
        }
    }

    return result;
}

Console.WriteLine("MultiplyPolynomials");
//Tests
//Positive
var positiveTestCases = new List<(int[], int[], int[])>
{
    (new[] { -1, 1 }, new[] { 2, 1 }, new[] { -2, 1, 1 }),
    (new[] { -1, 1, 1 }, new[] { 2, 1, 1 }, new[] { -2, 1, 2, 2, 1 }),
    (new[] { 1,1,-1,2,1 }, new[] { 0 }, new[] { 0,0,0,0,0 }),
    (new[] { 0,0,0,0,0 }, new[] { 0 }, new[] { 0,0,0,0,0 })
};

foreach (var testCase in positiveTestCases)
{
    var actual = MultiplyPolynomials(testCase.Item1, testCase.Item2);
    if (testCase.Item3.SequenceEqual(actual))
    {
        Console.WriteLine("Test passed.");
    }
    else
    {
        Console.WriteLine($"The test failed elements are not equal.");
    }
}
//Negative

try
{
    MultiplyPolynomials(null!, null!);

    Console.WriteLine("The test failed");
}
catch (ArgumentNullException)
{
    Console.WriteLine("Test passed.");
}
catch (Exception)
{
    Console.WriteLine("The test failed because was throw other exception");
}

try
{
    MultiplyPolynomials(Array.Empty<int>(),Array.Empty<int>());
        
    Console.WriteLine("The test failed");
}
catch (ArgumentException)
{
    Console.WriteLine("Test passed.");
}
catch (Exception)
{
    Console.WriteLine("The test failed because was throw other exception");
}

