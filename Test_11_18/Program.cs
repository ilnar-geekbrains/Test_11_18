using Test_11_18;

#region Написать программу для копирования массива

var arr = new double[] { 1, 2, 3, 4, 5, 6 };
var copy = arr.MakeCopy();

TestHelper.TrueExpression(() => arr != copy);
TestHelper.TrueExpression(() => arr.Length == copy.Length);
TestHelper.TrueExpression(() => Enumerable.SequenceEqual(arr, copy));
copy[0] = -1;
TestHelper.FalseExpression(() => Enumerable.SequenceEqual(arr, copy));

#endregion

#region Написать программу для операции "произведение массивов"

double[] multiplied;
double[] expected;

multiplied = ArrayHelper.MultiplyPolynomials(arr, copy);
expected = new double[] { -1, 0, 4, 12, 25, 44, 70, 76, 73, 60, 36 };
TestHelper.TrueExpression(() => Enumerable.SequenceEqual(multiplied, expected));

multiplied = ArrayHelper.MultiplyPolynomials(new double[] { -1, 1 },
                                             new double[] { 2, 1 });
expected = new double[] { -2, 1, 1 };
TestHelper.TrueExpression(() => Enumerable.SequenceEqual(multiplied, expected));

multiplied = ArrayHelper.MultiplyPolynomials(new double[] { 5, 0, 10, 6 },
                                             new double[] { 1, 2, 4 });
expected = new double[] { 5, 10, 30, 26, 52, 24 };
TestHelper.TrueExpression(() => Enumerable.SequenceEqual(multiplied, expected));

#endregion

