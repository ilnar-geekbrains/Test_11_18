// See https://aka.ms/new-console-template for more information

var a = ReadArray();
var b = ReadArray();

var result = PolynomMultiplier.Multiply(a, b);
Console.WriteLine(string.Join(" ", result));

int[] ReadArray() => Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

public static class PolynomMultiplier
{
    public static int[] Multiply(int[] a, int[] b)
    {
        if (a.Length == 0 || b.Length == 0)
            throw new ArgumentException();

        var resultRank = a.Length + b.Length - 1;
        var result = new int[resultRank];

        for (var i = 0; i < a.Length; i++)
        {
            for (var j = 0; j < b.Length; j++)
            {
                result[i + j] += a[i] * b[j];
            }
        }

        return result;
    }
}