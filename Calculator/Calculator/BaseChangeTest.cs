using CalculatorMultiBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class BaseChangeTest
    {
        [TestMethod]
        public void Base10To2()
        {
            Assert.AreEqual("110101100000", BaseChange.DecimalToArbitrarySystem(3424, 2));
        }

        [TestMethod]
        public void Base10To16()
        {
            Assert.AreEqual("314F", BaseChange.DecimalToArbitrarySystem(12623, 16));
        }

        [TestMethod]
        public void Base16To2()
        {
            var toDecimal = BaseChange.ArbitraryToDecimalSystem("3a4F", 16);
            Assert.AreEqual("11101001001111", BaseChange.DecimalToArbitrarySystem(toDecimal, 2));
        }
    }
}
