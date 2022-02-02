namespace ArrayMultiplication
{
    internal class ArrayMultiplier
    {
        /// <summary>
        /// Main Function. User input arrays is here. 
        /// </summary>
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Input: 1 - multiply arrays; 2 - run unit tests");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Input first array (example 1, 2, 3): ");
                        var firstInput = Console.ReadLine();

                        Console.WriteLine("Input second array (example 1, 2, 3): ");
                        var secondInput = Console.ReadLine();

                        var firstList = GetArray(firstInput);
                        var secondList = GetArray(secondInput);

                        var result = MultiplyArrays(firstList, secondList);

                        Console.WriteLine("Result of multiplication: [{0}]", string.Join(", ", result));
                        break;
                    case "2":
                        UnitTests.RunAll();
                        break;
                    default:
                        Console.WriteLine("Incorrect input, try again!");
                        break;
                }
            }

        }

        /// <summary>
        /// Function for multiply two arrays
        /// </summary>
        /// <param name="firstArray"> first arrays </param>
        /// <param name="secondArray"> second arrays </param>
        /// <returns></returns>
        public static decimal[] MultiplyArrays(decimal[] firstArray, decimal[] secondArray)
        {
            var fmLength = firstArray.Count();
            var smLength = secondArray.Count();

            // create new array, where index is degree for polynomial 
            var resultLength = fmLength + smLength - 1;

            if (resultLength < 0)
            {
                return new decimal[1] { 0 };
            }

            var result = new decimal[resultLength];

            for (int i = 0; i < fmLength; i++)
            {
                for (int j = 0; j < smLength; j++)
                {
                    result[i + j] += firstArray[i] * secondArray[j];
                }
            }
            result = result.SkipWhile(number => number == 0).ToArray();

            return result.Count() > 0 ? result : new decimal[1] { 0 };
        }

        /// <summary>
        /// Getting array from input string.
        /// </summary>
        /// <param name="input"> Input string </param>
        /// <returns> null is error. Positive result is getting of array from string </returns>
        public static decimal[] GetArray(string? input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return new decimal[0];
            }

            List<decimal> result = new List<decimal>();
            foreach (var element in input.Split(','))
            {
                // check, element is number
                var isValid = decimal.TryParse(element.Trim(), out decimal number);
                if (!isValid)
                {
                    return new decimal[0];
                }
                result.Add(number);
            }

            return result.ToArray();
        }
    }
}
