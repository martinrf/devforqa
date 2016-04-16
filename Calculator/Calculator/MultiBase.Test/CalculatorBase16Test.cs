namespace Calculator.MultiBase.Test
{
    using CalculatorMultiBase;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CalculatorBase16Test : CalculatorBaseBaseTest
    {
        public CalculatorBase16Test() : base(new CalculatorBase16())
        {
            this.TwentyOne = "15";
            this.FortyThree = "2B";
            this.FortyTwo = "2A";
            this.SixtyFour = "40";
            this.TwentyTwo = "16";
            this.NineZeroThree = "387";
            this.Two = "2";
        }

        public override void TestInitialize()
        {
        }
    }
}
