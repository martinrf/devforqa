namespace Kata.FizzBuzz.Implementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FizzBuzzTransformerExample : IFizzBuzzTransformer
    {
        public IEnumerable<string> Transform(IEnumerable<int> sequence)
        {
            var enumerable = sequence as int[] ?? sequence.ToArray();
            if (IsSequential(enumerable))
            {
                return enumerable.Select(FizzBuzz).ToList();
            }

            throw new ArgumentException("Not a Sequence");
        }

        private static string FizzBuzz(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
            {
                return "FizzBuzz";
            }

            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }

        private static bool IsSequential(IEnumerable<int> array)
        {
            var enumerable = array as int[] ?? array.ToArray();
            return enumerable.Zip(enumerable.Skip(1), (a, b) => (a + 1) == b).All(x => x);
        }
    }
}