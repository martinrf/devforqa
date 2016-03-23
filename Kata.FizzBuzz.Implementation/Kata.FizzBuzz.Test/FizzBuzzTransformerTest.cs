namespace Kata.FizzBuzz.Test
{
    using System;
    using System.Linq;
    using Implementation;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Summary description for FizzBuzzTransformerTest
    /// </summary>
    [TestClass]
    public class FizzBuzzTransformerTest
    {
        private IFizzBuzzTransformer _transformer;

        [TestInitialize]
        public void Setup()
        {
            this._transformer = new FizzBuzzTransformer();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotASequenceWithNegative()
        {
            int[] numbers = { -1, 3, 6 };
            this._transformer.Transform(numbers);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotASequencee()
        {
            int[] numbers = { 1, 3, 6 };
            this._transformer.Transform(numbers);
        }

        [TestMethod]
        public void OneToThree()
        {
            int[] numbers = { 1, 2, 3 };
            var result = this._transformer.Transform(numbers);
            string[] witness = { "1", "2", "Fizz" };
            CollectionAssert.AreEqual(witness, result.ToArray());
        }

        [TestMethod]
        public void OneToFive()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            var result = this._transformer.Transform(numbers);
            string[] witness = { "1", "2", "Fizz", "4", "Buzz" };
            CollectionAssert.AreEqual(witness, result.ToArray());
        }

        [TestMethod]
        public void OneToFifteen()
        {
            var numbers = Enumerable.Range(1, 15).ToArray();
            var result = this._transformer.Transform(numbers);
            string[] witness = { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
            CollectionAssert.AreEqual(witness, result.ToArray());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeNumbers()
        {
            int[] numbers = { -1, -2, -3, -4, -5 };
            var result = this._transformer.Transform(numbers);
        }
    }
}
