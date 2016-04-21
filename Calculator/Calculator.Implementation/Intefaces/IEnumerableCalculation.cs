namespace Calculator.Implementation.Intefaces
{
    using System.Collections.Generic;

    public interface IEnumerableCalculation
    {
        int Aggregate(IEnumerable<int> numbers);

        string Aggregate(IEnumerable<string> numbers, int radix);
    }
}
