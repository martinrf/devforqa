using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPSnippets.ClassesAndObjects;

namespace OOPSnippets.Test
{
    [TestClass]
    public class StaticClassTest3
    {
        [TestMethod]
        public void CounterValue()
        {
            int value = 4;
            Assert.AreEqual(value, StaticClass.GetCounter);
        }

        [TestMethod]
        public void CounterValue1()
        {
            int value = 5;
            Assert.AreEqual(value, StaticClass.GetCounter);
        }

        [TestMethod]
        public void CounterValue2()
        {
            int value = 6;
            Assert.AreEqual(value, StaticClass.GetCounter);
        }

        [TestMethod]
        public void CounterValue3()
        {
            int value = 7;
            Assert.AreEqual(value, StaticClass.GetCounter);
        }
    }
}
