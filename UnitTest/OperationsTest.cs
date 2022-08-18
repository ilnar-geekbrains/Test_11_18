using GeekBrainsTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class OperationsTest
    {
        [TestMethod]
        [DataRow(new[] { -1.0, 1 }, new[] { 2.0, 1.0 }, new[] { -2.0, 1.0,1.0 })]
        [DataRow(new[] { -1.0,  }, new[] { 2.0 }, new[] { -2.0 })]
        [DataRow(new[] { 3.0 , -1.0 }, new[] { 1.0, 1.0 ,2.0 }, new[] { 3.0, 2.0, 5.0, -2.0})]
        public void MultiplyTest(double[] source, double[] multiplierPolynom, double[] result)
        {
            PolynomialMultiplicationOperation operation = new PolynomialMultiplicationOperation();

            var multResult = operation.Multiply(source, multiplierPolynom);
            Assert.IsTrue(multResult.IsEqualsByValue(result));

            multResult = operation.Multiply(multiplierPolynom, source);
            Assert.IsTrue(multResult.IsEqualsByValue(result));
        }

        [TestMethod]
        [DataRow(new[] { 3.0, -1.0 })]
        public void CloneTest(double[] source)
        {
            var cloneArray = source.DeepClone();
            Assert.IsTrue(source.IsEqualsByValue(cloneArray));
            Assert.IsTrue(source != cloneArray);
        }
    }
}
