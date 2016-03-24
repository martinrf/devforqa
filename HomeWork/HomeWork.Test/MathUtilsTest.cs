using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework.Test
{
    [TestClass]
    public class MathUtilsTest
    {
        [TestMethod]
        public void Raiz9Es3()
        {
            Assert.AreEqual(3, MathUtils.RaizCuadrada(9));
        }

        [TestMethod]
        public void Sqrt8888Is94and52()
        {
            var input = 8888;

            Assert.AreEqual(94, 0);
            Assert.AreEqual(52, 0);
        }
    }
}
