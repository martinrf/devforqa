using System;
using CalculatorMultiBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class CalculatorBase2Test : CalculatorBaseBaseTest
    {
        public CalculatorBase2Test() : base(new CalculatorBase2())
        {
            this.TwentyOne = "10101";
            this.FortyThree = "101011";
            this.FortyTwo = "101010";
            this.SixtyFour = "1000000";
            this.TwentyTwo = "10110";
            this.NineZeroThree = "1110000111";
            this.Two = "10";
        }

        public override void TestInitialize(){}
    }
}
