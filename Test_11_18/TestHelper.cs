namespace Test_11_18;

public static class TestHelper
{
    public static void TrueExpression(Func<bool> expression)
    {
        if (expression.Invoke())
            Console.WriteLine("Тест пройден");
        else
            Console.WriteLine("Тест не пройден");
    }
    public static void FalseExpression(Func<bool> expression)
    {
        if (expression.Invoke())
            Console.WriteLine("Тест не пройден");
        else
            Console.WriteLine("Тест пройден");
    }
}
