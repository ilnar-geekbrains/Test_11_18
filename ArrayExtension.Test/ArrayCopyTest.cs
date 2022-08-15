namespace ArrayExtension.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        public void ArrayCopyTest(int[] sourceArray, int[] expectedArray)
        {
            //Assert
            int[] actualArray = new int[sourceArray.Length];

            //Are
            sourceArray.CopyExtension(actualArray);

            //Equal
            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestCase(null)]
        public void ArrayCopyNullRefernceTest(int[] sourceArray)
        {
            //Assert
            int[] actualArray = new int[4];

            //Equal
            Assert.Throws<NullReferenceException>(() => sourceArray.CopyExtension(actualArray));
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 })]
        public void ArrayCopyIdexOutOfRangeTest(int[] sourceArray)
        {
            //Assert
            int[] actualArray = new int[sourceArray.Length - 2];

            //Equal
            Assert.Throws<IndexOutOfRangeException>(() => sourceArray.CopyExtension(actualArray));
        }
    }
}