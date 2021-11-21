using System.Collections.Generic;
using ArrayDup.Console.GenerateRandom;
using NUnit.Framework;

namespace ArrayDup.Console.UnitTests.GenerateRandom
{
    public class GeneratorRandomArrayTests
    {
        [Test]
        public void GeneratorRandomArray_Generate_Test()
        {
            var actual = GeneratorRandomArray.Generate();
            Assert.IsInstanceOf<IEnumerable<int>>(actual);
        }
    }
}
