namespace Kata.FizzBuzz.Implementation
{
    using System.Collections.Generic;

    public interface IFizzBuzzTransformer
    {
        IEnumerable<string> Transform(IEnumerable<int> sequence);
    }
}
