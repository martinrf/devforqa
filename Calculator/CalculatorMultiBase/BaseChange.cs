using System;

namespace CalculatorMultiBase
{
    /// http://www.pvladov.com/2012/05/decimal-to-arbitrary-numeral-system.html
    /// http://www.pvladov.com/2012/07/arbitrary-to-decimal-numeral-system.html
    public static class BaseChange
    {
        /// <summary>
        /// Converts the given decimal number to the numeral system with the
        /// specified radix (in the range [2, 36]).
        /// </summary>
        /// <param name="decimalNumber">The number to convert.</param>
        /// <param name="radix">The radix of the destination numeral system
        /// (in the range [2, 36]).</param>
        /// <returns></returns>
        public static string DecimalToArbitrarySystem(long decimalNumber, int radix)
        {
            const int bitsInLong = 64;
            const string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (radix < 2 || radix > digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " + digits.Length);

            if (decimalNumber == 0)
                return "0";

            var index = bitsInLong - 1;
            var currentNumber = Math.Abs(decimalNumber);
            var charArray = new char[bitsInLong];

            while (currentNumber != 0)
            {
                var remainder = (int)(currentNumber % radix);
                charArray[index--] = digits[remainder];
                currentNumber = currentNumber / radix;
            }

            var result = new string(charArray, index + 1, bitsInLong - index - 1);
            if (decimalNumber < 0)
            {
                result = "-" + result;
            }

            return result;
        }

        /// <summary>
        /// Converts the given number from the numeral system with the specified
        /// radix (in the range [2, 36]) to decimal numeral system.
        /// </summary>
        /// <param name="number">The arbitrary numeral system number to convert.</param>
        /// <param name="radix">The radix of the numeral system the given number
        /// is in (in the range [2, 36]).</param>
        /// <returns></returns>
        public static long ArbitraryToDecimalSystem(string number, int radix)
        {
            const string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (radix < 2 || radix > digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " + digits.Length);

            if (string.IsNullOrEmpty(number))
                return 0;

            number = number.ToUpperInvariant();

            long result = 0;
            long multiplier = 1;
            for (var i = number.Length - 1; i >= 0; i--)
            {
                var c = number[i];
                if (i == 0 && c == '-')
                {
                    result = -result;
                    break;
                }

                var digit = digits.IndexOf(c);
                if (digit == -1)
                    throw new ArgumentException("Invalid character in the arbitrary numeral system number",nameof(number));

                result += digit * multiplier;
                multiplier *= radix;
            }

            return result;
        }
    }
}
