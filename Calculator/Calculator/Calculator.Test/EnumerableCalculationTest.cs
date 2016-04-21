namespace Calculator.Calculator.Test
{
    using System;
    using System.Linq;
    using Implementation;
    using Implementation.Intefaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public abstract class EnumerableCalculationTest
    {
        protected IEnumerableCalculation Iteration;

        [TestMethod]
        public void Range1To3Is6()
        {
            Assert.AreEqual(6, this.Iteration.Aggregate(Enumerable.Range(1, 3).ToArray()));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Null()
        {
            Assert.AreEqual(0, this.Iteration.Aggregate(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Empty()
        {
            Assert.AreEqual(0, this.Iteration.Aggregate(new int[0]));
        }

        [TestMethod]
        public void NegativeNumbers()
        {
            Assert.AreEqual(7, this.Iteration.Aggregate(new[] { -3, 4, -11, 14, 3 }));
        }

        [TestMethod]
        public void Radix2Aggregation()
        {
            Assert.AreEqual("10000000", this.Iteration.Aggregate(new [] { "10101", "101011", "1000000" }, 2));
        }

        [TestClass]
        public class ForEachTest : EnumerableCalculationTest
        {
            [TestInitialize]
            public void Setup()
            {
                this.Iteration = new ForEachImplementation();
            }
        }

        [TestClass]
        public class DoWhileTest : EnumerableCalculationTest
        {
            [TestInitialize]
            public void Setup()
            {
                this.Iteration = new DoWhileImplementation();
            }
        }

        [TestClass]
        public class WhileTest : EnumerableCalculationTest
        {
            [TestInitialize]
            public void Setup()
            {
                this.Iteration = new WhileImplementation();
            }
        }

        [TestClass]
        public class UsingLinqTest : EnumerableCalculationTest
        {
            [TestInitialize]
            public void Setup()
            {
                this.Iteration = new UsingLinqImplementation();
            }
        }

        [TestClass]
        public class ForImplementationTest : EnumerableCalculationTest
        {
            [TestInitialize]
            public void Setup()
            {
                this.Iteration = new ForImplementation();
            }
        }
    }
}
