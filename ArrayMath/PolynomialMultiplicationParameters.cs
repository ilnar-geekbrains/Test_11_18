using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMath
{
	internal class PolynomialMultiplicationContext
	{
		public PolynomialMultiplicationContext(int[] firstArray, int[] secondArray)
		{
			FirstArray = firstArray;
			SecondArray = secondArray;
		}

		public int FirstPolinomialIndex { get; set; }
		public int FirstArrayStartIndex { get; set; }
		public int SecondArrayStartIndex { get; set; } = 0;
		public int LessArrayIndex { get; set; }
		public int LessArrayLength { get; set; }
		public int[] FirstArray { get; }
		public int[] SecondArray { get; }
	}
}
