namespace GeekBrainsTest.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new int[] { 2, 4, 6, 45 })]
        [TestCase(new int[] { 2, 4, 6 })]
        [TestCase(new int[] { 2, 4, 6, 45, 456, 234, 13 })]
        public void CopyArray_Success(int[] arr)
        {
            // ARRANGE
            int[] copiedArr;


            // ACT
            copiedArr = Tasks.CopyArray(arr);


            // ASSERT
            Assert.IsTrue(copiedArr.SequenceEqual(arr));
        }

        [Test]
        [TestCase(null)]
        public void CopyArray_Failure(int[] arr)
        {
            // ARRANGE
            int[] copiedArr;


            // ACT
            


            // ASSERT
            Assert.Throws<NullReferenceException>(() =>
            {
                Tasks.CopyArray(arr);
            });
        }
    }
}