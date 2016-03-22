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
    }
}
