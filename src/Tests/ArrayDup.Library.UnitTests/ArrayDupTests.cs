using System.Collections.Generic;
using NUnit.Framework;

namespace ArrayDup.Library.UnitTests
{
    public class ArrayDupTests
    {
        [Test]
        public void ArrayDup1_Constructor_Test()
        {
            ArrayDup<int> underTest = null;
            Assert.DoesNotThrow(() => underTest = new ArrayDup<int>());
            Assert.IsInstanceOf<IArrayDup<int>>(underTest);
        }

        [Test]
        public void ArrayDup1_Copy_Test()
        {
            var data = new int[] { 1, 2, 3 };
            var underTest = new ArrayDup<int>();
            var actual = underTest.Copy(data);
            CollectionAssert.AreEqual(data, actual);
            Assert.AreNotSame(data, actual);
        }

        [Test]
        public void ArrayDup2_Constructor_Test()
        {
            ArrayDup<int, int> underTest = null;
            Assert.DoesNotThrow(() => underTest = new ArrayDup<int, int>());
            Assert.IsInstanceOf<IArrayDup<int, int>>(underTest);
        }

        [Test]
        public void ArrayDup2_Copy_Test()
        {
            var data = new int[] { 1, 2, 3 };
            var underTest = new ArrayDup<int, int>();
            var actual = underTest.Copy(data);
            CollectionAssert.AreEqual(data, actual);
            Assert.AreNotSame(data, actual);
        }

        [Test]
        public void ArrayDup2_Copy_ToOtherType_Test()
        {
            var data = new string[] { "1", "2", "3" };
            var underTest = new ArrayDup<string, IEnumerable<char>>();
            var actual = underTest.Copy(data);
            CollectionAssert.AreEqual(actual, data);
        }
    }
}