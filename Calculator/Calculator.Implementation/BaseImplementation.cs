namespace Calculator.Implementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CalculatorMultiBase;

    public abstract class BaseImplementation : IEnumerableCalculation
    {
        protected int Total = 0;

        protected IEnumerable<int> Numbers;

        private string ConvertedTotal => BaseChange.DecimalToArbitrarySystem(this.Total, this._radix);

        private int _radix;

        public int Aggregate(IEnumerable<int> numbers)
        {
            this.SetNumbers(numbers);
            this.DoAggregation();
            return this.Total;
        }

        public string Aggregate(IEnumerable<string> numbers, int radix)
        {
            this.SetRadix(radix);
            this.SetNumbers(numbers);
            this.DoAggregation();
            return this.ConvertedTotal;
        }

        protected abstract void DoAggregation();

        private void SetNumbers(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException();
            }

            if (!numbers.GetEnumerator().MoveNext())
            {
                throw new ArgumentException();
            }
            
            this.Numbers = numbers;
        }

        private void SetNumbers(IEnumerable<string> numbers)
        {
            this.SetNumbers(this.ConvertNumbers(numbers));
        }

        private void SetRadix(int radix)
        {
            this._radix = radix;
        }
        
        private IEnumerable<int> ConvertNumbers(IEnumerable<string> numbers)
        {
            return numbers.Select(number => (int)BaseChange.ArbitraryToDecimalSystem(number, this._radix)).ToArray();
        }
    }
}
