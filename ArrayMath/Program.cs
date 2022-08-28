using ArrayMath;

var firstArray = new int[] {1,0,1,-2,0,3 };
var secondArray = new int[] {2,-3,4,0,-1 };

firstArray.PolynomialMultiplication(secondArray).ToList().ForEach(x => Console.WriteLine(x));