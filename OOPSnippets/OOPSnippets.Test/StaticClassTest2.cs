using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPSnippets.ClassesAndObjects;

namespace OOPSnippets.Test
{
    [TestClass]
    public class StaticClassTest2
    {
        [TestMethod]
        public void CounterValue()
        {
            int value = 0;
            Assert.AreEqual(value, StaticClass.GetCounter);
        }

        [TestMethod]
        public void CounterValue1()
        {
            int value = 1;
            Assert.AreEqual(value, StaticClass.GetCounter);
        }

        [TestMethod]
        public void CounterValue2()
        {
            int value = 2;
            Assert.AreEqual(value, StaticClass.GetCounter);
        }

        [TestMethod]
        public void CounterValue3()
        {
            int value = 3;
            Assert.AreEqual(value, StaticClass.GetCounter);
        }
    }
}
