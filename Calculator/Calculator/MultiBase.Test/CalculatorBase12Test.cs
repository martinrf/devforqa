namespace Calculator.MultiBase.Test
{
    using CalculatorMultiBase;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CalculatorBase12Test : CalculatorBaseBaseTest
    {

        public CalculatorBase12Test() : base(new CalculatorBase12())
        {
            this.TwentyOne = "19";
            this.FortyThree = "37";
            this.FortyTwo = "36";
            this.SixtyFour = "54";
            this.TwentyTwo = "1A";
            this.NineZeroThree = "633";
            this.Two = "2";
        }

        public override void TestInitialize()
        {
        }
    }
}
