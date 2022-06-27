
// Polynomial multiplication function

int[] MultiplyPolynomials(int[] polynomialA, int[] polynomialB)
{
  int dimension = (polynomialA.Length -1) + (polynomialB.Length - 1);
  int[] result = new int[dimension + 1];

  for (int i=0; i<polynomialA.Length; i++){
    for (int j=0; j<polynomialB.Length; j++) {
      int position = i + j;
      result[position] += polynomialA[i] * polynomialB[j];
    }
  }
  return result;  
}


// Testing

void multiplicationAssert(string label, int[] polynomialA, int[] polynomialB, int[] result)
{
  int[] multiplicationResult = MultiplyPolynomials(polynomialA, polynomialB);
  if (result.SequenceEqual(multiplicationResult))
  {
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine($"{label} - valid");
  } 
  else 
  {
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine($"{ label }  - invalid. Result: {String.Join(',', multiplicationResult)}");
  }
}

// Test 1

int[] polynomialA1 = {-1, 1},
  polynomialB1 = {2, 1};
int[] result1 = {-2, 1, 1};

multiplicationAssert("Test 1", polynomialA1, polynomialB1, result1);


// Test 2

int[] polynomialA2 = {2, -3},
  polynomialB2 = {2, 1, 4};
int[] result2 = {4, -4, 5, -12};

multiplicationAssert("Test 2", polynomialA2, polynomialB2, result2);

// Test 3

int[] polynomialA3 = {3, -5, 0, 7},
  polynomialB3 = {1, 2};
int[] result3 = {3, 1, -10, 7, 14};

multiplicationAssert("Test 3", polynomialA3, polynomialB3, result3);
