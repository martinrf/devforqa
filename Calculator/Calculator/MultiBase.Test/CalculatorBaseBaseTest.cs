namespace Calculator.MultiBase.Test
{
    using CalculatorMultiBase;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public abstract class CalculatorBaseBaseTest
    {
        private readonly ICalculator _calculator;
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
            Assert.AreEqual(this.SixtyFour, this._calculator.Addition(this.TwentyOne, this.FortyThree));
        }

        [TestMethod]
        public void Substraction21To43()
        {
            Assert.AreEqual(this.TwentyTwo, this._calculator.Substraction(this.FortyThree, this.TwentyOne));
        }

        [TestMethod]
        public void Multiplication21And43()
        {
            Assert.AreEqual(this.NineZeroThree, this._calculator.Multiplication(this.FortyThree, this.TwentyOne));
        }

        [TestMethod]
        public void Division42And21()
        {
            Assert.AreEqual(this.Two, this._calculator.Division(this.FortyTwo, this.TwentyOne));
        }
    }
}
