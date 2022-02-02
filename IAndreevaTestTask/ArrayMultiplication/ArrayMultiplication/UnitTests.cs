namespace ArrayMultiplication
{
    internal static class UnitTests
    {
        public static void RunAll()
        {
            Console.WriteLine($@"1) Unit test for MultiplyArrays() is { (Success_MultiplyArrays_ForWholeNumbers() ? "true" : "false") }");
            Console.WriteLine($@"2) Unit test for MultiplyArrays() is { (Success_MultiplyArrays_ForDecimals() ? "true" : "false") }");
            Console.WriteLine($@"3) Unit test for MultiplyArrays() is { (Success_MultiplyArrays_FirstIsEmpty() ? "true" : "false") }");
            Console.WriteLine($@"4) Unit test for MultiplyArrays() is { (Success_MultiplyArrays_SecondIsEmpty() ? "true" : "false") }");
            Console.WriteLine($@"5) Unit test for MultiplyArrays() is { (Success_MultiplyArrays_BothAreEmpty() ? "true" : "false") }");
            Console.WriteLine($@"6) Unit test for MultiplyArrays() is { (Success_MultiplyArrays_LeadingZeroes() ? "true" : "false") }");

            Console.WriteLine($@"7) Unit test for GetArray() is { (Success_GetArray_Number() ? "true" : "false") }");
            Console.WriteLine($@"8) Unit test for GetArray() is { (Fail_GetArray_NotNumber() ? "true" : "false") }");
            Console.WriteLine($@"9) Unit test for GetArray() is { (Fail_GetArray_IsEmpty() ? "true" : "false") }");
        }

        public static bool Success_MultiplyArrays_ForWholeNumbers()
        {
            // Arrange
            var firstArray = new decimal[2] { -1, 1 };
            var secondArray = new decimal[2] { 2, 1 };

            // Act
            var result = ArrayMultiplier.MultiplyArrays(firstArray, secondArray);

            // Assert
            return result.SequenceEqual(new decimal[3] { -2, 1, 1});
        }

        public static bool Success_MultiplyArrays_ForDecimals()
        {
            // Arrange
            var firstArray = new decimal[2] { -1.0m, 1.0m };
            var secondArray = new decimal[2] { 2.0m, 1.0m };

            // Act
            var result = ArrayMultiplier.MultiplyArrays(firstArray, secondArray);

            // Assert
            return result.SequenceEqual(new decimal[3] { -2.0m, 1.0m, 1.0m });
        }

        public static bool Success_MultiplyArrays_FirstIsEmpty()
        {
            // Arrange
            var firstArray = new decimal[0] { };
            var secondArray = new decimal[2] { 2, 1 };

            // Act
            var result = ArrayMultiplier.MultiplyArrays(firstArray, secondArray);

            // Assert
            return result.SequenceEqual(new decimal[1] { 0 });
        }

        public static bool Success_MultiplyArrays_SecondIsEmpty()
        {
            // Arrange
            var firstArray = new decimal[2] { 2, 1 };
            var secondArray = new decimal[0] { };

            // Act
            var result = ArrayMultiplier.MultiplyArrays(firstArray, secondArray);

            // Assert
            return result.SequenceEqual(new decimal[1] { 0 });
        }

        public static bool Success_MultiplyArrays_BothAreEmpty()
        {
            // Arrange
            var firstArray = new decimal[0] { };
            var secondArray = new decimal[0] { };

            // Act
            var result = ArrayMultiplier.MultiplyArrays(firstArray, secondArray);

            // Assert
            return result.SequenceEqual(new decimal[1] { 0 });
        }

        public static bool Success_MultiplyArrays_LeadingZeroes()
        {
            // Arrange
            var firstArray = new decimal[3] { 0, 0, 0 };
            var secondArray = new decimal[3] { 0, 0, 1 };

            // Act
            var result = ArrayMultiplier.MultiplyArrays(firstArray, secondArray);

            // Assert
            return result.SequenceEqual(new decimal[1] { 0 });
        }

        public static bool Success_GetArray_Number()
        {
            // Arrange
            var input = "1, 2, 3";

            // Act
            var result = ArrayMultiplier.GetArray(input);

            // Assert
            return result != null && result.SequenceEqual(new decimal[3] { 1, 2, 3 });
        }

        public static bool Fail_GetArray_NotNumber()
        {
            // Arrange
            var input = "sdasdasd";

            // Act
            var result = ArrayMultiplier.GetArray(input);

            // Assert
            return result.Count() == 0;
        }

        public static bool Fail_GetArray_IsEmpty()
        {
            // Arrange
            var input = "";

            // Act
            var result = ArrayMultiplier.GetArray(input);

            // Assert
            return result.Count() == 0;
        }
    }
}
