using System;
using System.Collections.Generic;

namespace ArrayDup.Console.GenerateRandom
{
    public static class GeneratorRandomArray
    {
        private static Random rnd = new Random();

        public static IEnumerable<int> Generate()
        {
            var count = rnd.Next(2, 10);
            var answer = new List<int>();
            for (var i = 0; i < count; i++)
            {
                answer.Add(rnd.Next(100));
            }

            return answer;
        }
    }
}
