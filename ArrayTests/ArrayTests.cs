using ArrayMath;

namespace ArrayTests
{
	public class ArrayTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void CopyIntArrayValidTest()
		{
			// Arrange:
			var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// Act:
			var copiedArray = array.Copy();

			// Assert:
			AssertArray(array, copiedArray);
		}

		[Test]
		public void CopyDoubleIntArrayValidTest()
		{
			// Arrange:
			var array = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };

			// Act:
			var copiedArray = array.Copy();

			// Assert:
			AssertArray(array, copiedArray);
		}

		[Test]
		public void CopyStringIntArrayValidTest()
		{
			// Arrange:
			var array = new string[] { "1", "2", "3", "4", "5", "6", "7" };

			// Act:
			var copiedArray = array.Copy();

			// Assert:
			AssertArray(array, copiedArray);
		}

		[Test]
		public void CopyEmptyArrayValidTest()
		{
			// Arrange:
			var array = new int[0];

			// Act:
			var copiedArray = array.Copy();

			// Assert:
			AssertArray(array, copiedArray);
		}

		[Test]
		public void CopyArrayWithNullValues()
		{
			// Arrange:
			var array = new string[] { null, null, null, null };

			// Act:
			var copiedArray = array.Copy();
			
			// Assert:
			AssertArray(array, copiedArray);
		}

		[Test]
		public void BigPolynomialMultiplicationValidTest()
		{
			// Arrange:
			var firstArray = new int[] { 1, 0, 1, -2, 0, 3 };
			var secondArray = new int[] { 2, -3, 4, 0, -1 };
			var expectedResult = new int[] { 2, -3, 6, -7, 9, -2, -10, 14, 0, -3 };

			// Act:
			var result = firstArray.PolynomialMultiplication(secondArray);

			// Assert:
			AssertArray(expectedResult, result);
		}

		[Test]
		public void SmallPolynomialMultiplicationValidTest()
		{
			// Arrange:
			var firstArray = new int[] { -1, 1};
			var secondArray = new int[] { 2, 1};
			var expectedResult = new int[] { -2, 1, 1};

			// Act:
			var result = firstArray.PolynomialMultiplication(secondArray);

			// Assert:
			AssertArray(expectedResult, result);
		}

		[Test]
		public void PolynomialMultiplicationNullArrayValidTest()
		{
			// Arrange:
			var firstArray = new int[] { -1, 1 };
			int[] secondArray = null;

			// Act:
			var result = firstArray.PolynomialMultiplication(secondArray);

			// Assert:
			Assert.That(result, Is.Null);
		}

		[Test]
		public void PolynomialMultiplicatioSecondArrayEmptyValidTest()
		{
			// Arrange:
			var firstArray = new int[] { -1, 1 };
			var secondArray = new int[0];

			// Act:
			var result = firstArray.PolynomialMultiplication(secondArray);

			// Assert:
			Assert.That(result, Is.Null);
		}

		[Test]
		public void PolynomialMultiplicatioFirstArrayEmptyValidTest()
		{
			// Arrange:
			var firstArray = new int[0];
			var secondArray = new int[] { -1, 1 };

			// Act:
			var result = firstArray.PolynomialMultiplication(secondArray);

			// Assert:
			Assert.That(result, Is.Null);
		}

		private static void AssertArray<T>(T[] array, T[] copiedArray)
		{
			Assert.Multiple(() =>
			{
				Assert.That(copiedArray.Length, Is.EqualTo(array.Length));
				for (int i = 0; i < array.Length; i++)
				{
					Assert.That(copiedArray[i], Is.EqualTo(array[i]));
				}
			});
		}
	}
}