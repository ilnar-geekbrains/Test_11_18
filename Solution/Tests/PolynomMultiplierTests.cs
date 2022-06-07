using FluentAssertions;

namespace Tests;

public class PolynomMultiplierTests
{
    [Test]
    public void ShouldWorkOnExample()
    {
        PolynomMultiplier
            .Multiply(new[] { -1, 1 }, new[] { 2, 1 })
            .Should()
            .Equal(-2, 1, 1);
    }

    [Test]
    public void ShouldWorkOnOtherTest()
    {
        // 5*x^2 * x = 5*x^3
        PolynomMultiplier
            .Multiply(new[] { 0, 0, 5 }, new[] { 0, 1 })
            .Should()
            .Equal(0, 0, 0, 5);
    }
}