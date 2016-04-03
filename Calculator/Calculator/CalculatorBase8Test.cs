using CalculatorMultiBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class CalculatorBase8Test : CalculatorBaseBaseTest
    {
        public CalculatorBase8Test() : base(new CalculatorBase8())
        {
            this.TwentyOne = "25";
            this.FortyThree = "53";
            this.FortyTwo = "52";
            this.SixtyFour = "100";
            this.TwentyTwo = "26";
            this.NineZeroThree = "1607";
            this.Two = "2";
        }

        public override void TestInitialize(){}
    }
}
