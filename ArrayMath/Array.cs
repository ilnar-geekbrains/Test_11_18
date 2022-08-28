namespace ArrayMath
{
	public static class ArrayCaclulatorExtension
	{
		public static T[] Copy<T>(this T[] array)
		{
			var copiedArray = new T[array.Length];

			for (int i = 0; i < array.Length; i++)
			{
				copiedArray[i] = array[i];
			}

			return copiedArray;
		}

		public static T[] CopyByArrayMethod<T>(this T[] array)
		{
			var copiedArray = new T[array.Length];
			array.CopyTo(copiedArray, 0);

			return copiedArray;
		}

		public static int[] PolynomialMultiplication(this int[] firstArray, int[] secondArray)
		{
			if (secondArray is null || secondArray.Length == 0 || firstArray.Length == 0)
				return null;

			return GetResult(firstArray, secondArray);
		}

		private static int[] GetResult(int[] firstArray, int[] secondArray)
		{
			var context = new PolynomialMultiplicationContext(firstArray, secondArray);

			var coefficientCount = firstArray.Length + secondArray.Length - 1;

			var result = new int[coefficientCount];
			GetCoefficient(context, result);
			return result;
		}

		private static void GetCoefficient(PolynomialMultiplicationContext context, int[] result)
		{
			for (var i = 0; i < result.Length; i++)
			{
				context.FirstArrayStartIndex = i;
				context.FirstPolinomialIndex = i;

				if (i > context.FirstArray.Length - 1)
				{
					context.FirstArrayStartIndex = context.FirstArray.Length - 1;
					context.SecondArrayStartIndex++;
				}

				context.LessArrayIndex = context.SecondArrayStartIndex;
				context.LessArrayLength = context.SecondArray.Length;
				CalculateCoefficients(context, result);
			}
		}

		private static void CalculateCoefficients(PolynomialMultiplicationContext context, int[] result)
		{
			for (var j = context.FirstArrayStartIndex; GetConditionOfCalculation(context, j); j--)
			{
				if (context.LessArrayIndex >= context.SecondArray.Length)
					break;

				result[context.FirstPolinomialIndex] += context.FirstArray[j] * context.SecondArray[context.LessArrayIndex];
				context.LessArrayIndex++;
			}
		}

		private static bool GetConditionOfCalculation(PolynomialMultiplicationContext context, int j)
			=> j == 0 
				|| (j >= context.FirstArrayStartIndex -
					context.SecondArrayStartIndex - 1 && j > 0 
					&& context.LessArrayIndex < 
					context.FirstArrayStartIndex)
				|| (j > 0 && context.LessArrayIndex >= 
					context.FirstArrayStartIndex && 
					context.SecondArrayStartIndex == 0)
				|| (j > 0 && context.LessArrayIndex < 
					context.LessArrayLength);
	}
}
