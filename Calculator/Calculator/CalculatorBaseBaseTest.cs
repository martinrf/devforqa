using CalculatorMultiBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public abstract class CalculatorBaseBaseTest
    {
        private ICalculator _calculator;
        protected string SixtyFour;
        protected string TwentyOne;
        protected string FortyThree;
        protected string TwentyTwo;
        protected string NineZeroThree;
        protected string Two;
        protected string FortyTwo;

        protected CalculatorBaseBaseTest(ICalculator calculator)
        {
            this._calculator = calculator;
        }

        [TestInitialize]
        public void Setup()
        {
            TestInitialize();
        }

        public abstract void TestInitialize();

        [TestMethod]
        public void Addition21To43()
        {
            Assert.AreEqual(SixtyFour, this._calculator.Addition(TwentyOne, FortyThree));
        }

        [TestMethod]
        public void Substraction21To43()
        {
            Assert.AreEqual(TwentyTwo, this._calculator.Substraction(FortyThree, TwentyOne));
        }

        [TestMethod]
        public void Multiplication21And43()
        {
            Assert.AreEqual(NineZeroThree, this._calculator.Multiplication(FortyThree, TwentyOne));
        }

        [TestMethod]
        public void Division42And21()
        {
            Assert.AreEqual(Two, this._calculator.Division(FortyTwo, TwentyOne));
        }
    }
}
