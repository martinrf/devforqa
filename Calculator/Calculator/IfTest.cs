namespace Calculator
{
    using System.Runtime.InteropServices;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IfTest
    {
        private bool A { get; set; }
        private bool B { get; set; }

        [TestMethod]
        public void IfA()
        {
            this.A = true;
            Assert.AreEqual("A", this.IfThingy());
        }

        [TestMethod]
        public void IfB()
        {
            this.B = true;
            Assert.AreEqual("B", this.IfThingy());
        }

        [TestMethod]
        public void IfC()
        {
            Assert.AreEqual("C", this.IfThingy());
        }


        [TestMethod]
        public void IfOther()
        {
            this.A = true;
            this.B = true;
            Assert.AreEqual("A", this.IfThingy());
        }

        public string IfAndsThings()
        {
            if (this.A & this.B)
            {
                return "Perro";
            }

            if (this.A && this.B & this.A)
            {
                return "Gato";
            }

            return string.Empty;
        }

        public string IfThingy()
        {
            var aux = "C";
            if (this.A)
            {
                aux = "A";
            }

            if (!this.A && this.B)
            {
                aux = "B";
            }

            return aux;
        }
    }
}
