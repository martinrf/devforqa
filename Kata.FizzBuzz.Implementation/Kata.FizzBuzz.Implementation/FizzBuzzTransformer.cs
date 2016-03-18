using System.Data;

namespace Kata.FizzBuzz.Implementation
{
    using System;
    using System.Collections.Generic;

    public class FizzBuzzTransformer : IFizzBuzzTransformer
    {
        public IEnumerable<string> Transform(IEnumerable<int> sequence)
        {
            var miLista = new List<String>();
            foreach (var number in sequence)
            {
                if (number>0)
                {
                    if (number%3 ==0 && number%5==0)
                    {
                         miLista.Add("FizzBuzz");
                    } else if (number % 3 == 0)
                    {
                        miLista.Add("Fizz");
                    }else if (number % 5 == 0)
                    {
                        miLista.Add("Buzz");
                    }
                    else
                    {
                        miLista.Add(number.ToString());
                    }
                }
                else
                {
                    throw new ArgumentException("Valor negativo");
                }
            }
            return miLista;
        }
    }
}
