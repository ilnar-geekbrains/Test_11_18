namespace GeekBrainsTasks;

[TestClass]
public class GeekBrainsTests
{
    [TestMethod]
    public void TestMethodTask1Int()
    {
        int[] originArray = { 10, 20, 30 };
        var copiedArray = GeekBrainsTasks.CopyArray<int>(originArray);
        CollectionAssert.AreEqual(originArray, copiedArray);
    }

    [TestMethod]
    public void TestMethodTask1String()
    {
        string[] originArray = { "ss", "zz", "xx" };
        var copiedArray = GeekBrainsTasks.CopyArray<string>(originArray);
        CollectionAssert.AreEqual(originArray, copiedArray);
    }

    [TestMethod]
    public void TestMethodTask1Bool()
    {
        bool[] originArray = { true, false, true };
        var copiedArray = GeekBrainsTasks.CopyArray<bool>(originArray);
        CollectionAssert.AreEqual(originArray, copiedArray);
    }

    [TestMethod]
    public void TestMethodTask2_1()
    {
        int[] firstPolinom = { -1, 1 };
        int[] secondPolinom = { 2, 1 };
        int[] rightAnswer = { -2, 1, 1 };
        var multipliedPolynom = GeekBrainsTasks.MultiplyPolinom(firstPolinom, secondPolinom);
        CollectionAssert.AreEqual(rightAnswer, multipliedPolynom);
    }

    [TestMethod]
    public void TestMethodTask2_2()
    {
        int[] firstPolinom = { 3, 2, 1 };
        int[] secondPolinom = { 3, 2, 1 };
        int[] rightAnswer = { 9, 12, 10, 4, 1 };
        var multipliedPolynom = GeekBrainsTasks.MultiplyPolinom(firstPolinom, secondPolinom);
        CollectionAssert.AreEqual(rightAnswer, multipliedPolynom);
    }

    [TestMethod]
    public void TestMethodTask2_3()
    {
        int[] firstPolinom = { 3, 3, 2, 1 };
        int[] secondPolinom = { 3, 3, 2, 1 };
        int[] rightAnswer = { 9, 18, 21, 18, 10, 4, 1 };
        var multipliedPolynom = GeekBrainsTasks.MultiplyPolinom(firstPolinom, secondPolinom);
        CollectionAssert.AreEqual(rightAnswer, multipliedPolynom);
    }

    [TestMethod]
    public void TestMethodTask2_4()
    {
        int[] firstPolinom = { 10, 3, 3, 2, 1 };
        int[] secondPolinom = { 10, 3, 3, 2, 1 };
        int[] rightAnswer = { 100, 60, 69, 58, 41, 18, 10, 4, 1 };
        var multipliedPolynom = GeekBrainsTasks.MultiplyPolinom(firstPolinom, secondPolinom);
        CollectionAssert.AreEqual(rightAnswer, multipliedPolynom);
    }
}
