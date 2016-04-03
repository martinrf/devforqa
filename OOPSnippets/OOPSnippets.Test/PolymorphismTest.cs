using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPSnippets.Polymorphism;
using OOPSnippets.Polymorphism.Models;

namespace OOPSnippets.Test
{
    [TestClass]
    public class PolymorphismTest
    {
        private HeaderModel _model;

        [TestInitialize]
        public void Setup()
        {
            this._model = new HeaderModel
            {
                Date = new DateTime(2002, 10, 2),
                Price = 22.4m,
                PropertyName = "Test Item"
            };
            ////https://msdn.microsoft.com/es-es/library/system.globalization.cultureinfo(v=vs.110).aspx
            ////Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            ////Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
        }

        [TestMethod]
        public void ForLease()
        {
            var formatter = new ForLeaseFormatter(this._model);
            VerifyLineTwo(formatter);
            Assert.AreEqual("For Lease Price: 22,4", formatter.LineOne);
        }

        [TestMethod]
        public void ForSale()
        {
            var formatter = new ForSaleHeaderFormatter(this._model);
            VerifyLineTwo(formatter);
            Assert.AreEqual("For Sale Price: 22,4", formatter.LineOne);
        }

        [TestMethod]
        public void Property()
        {
            var formatter = new PropertyHeaderFormatter(this._model);
            VerifyLineOne(formatter);
            Assert.AreEqual("Property Name: Test Item", formatter.LineTwo);
        }

        private static void VerifyLineOne(HeaderFormatter formatter)
        {
            Assert.AreEqual("Price: 22,4", formatter.LineOne);
        }

        private static void VerifyLineTwo(HeaderFormatter formatter)
        {
            Assert.AreEqual("Date: 02/10/2002 0:00:00", formatter.LineTwo);
        }
    }
}
