namespace HowToLinq
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Projections
    {
        private ICollection<Property> _properties;
        private ICollection<Customer> _customers;

        [TestInitialize]
        public void Setup()
        {
            this.InitializeEntities();
        }

        [TestMethod]
        public void SelectingItems()
        {
        }

        private void InitializeEntities()
        {
            this._properties = new List<Property>
            {
                new Property
                {
                    Name = "Property 1",
                    DateInMarket = new DateTime(2016, 1, 12),
                    Rating = 2,
                    SalePrice = 325465m,
                    Currency = Currency.Dollar
                },
                new Property
                {
                    Name = "Property 2",
                    DateInMarket = new DateTime(2016, 3, 6),
                    Rating = 4,
                    SalePrice = 225468m,
                    Currency = Currency.Dollar
                },
                new Property
                {
                    Name = "Property 3",
                    DateInMarket = new DateTime(2016, 2, 9),
                    Rating = 3,
                    SalePrice = 117755m,
                    Currency = Currency.Dollar
                },
                new Property
                {
                    Name = "Property 4",
                    DateInMarket = new DateTime(2016, 2, 11),
                    Rating = 3,
                    SalePrice = 33244m,
                    Currency = Currency.Dollar
                },
                new Property
                {
                    Name = "Property 3",
                    DateInMarket = new DateTime(2016, 2, 9),
                    Rating = 3,
                    SalePrice = 117755m,
                    Currency = Currency.Euro
                },
                new Property
                {
                    Name = "Property 4",
                    DateInMarket = new DateTime(2016, 2, 11),
                    Rating = 3,
                    SalePrice = 33244m,
                    Currency = Currency.Euro
                },
            };
            this._customers = new List<Customer>
            {
                new Customer
                {
                    Name = "Customer 1",
                    Currency = Currency.Euro,
                    Rating = 59
                },
                new Customer
                {
                    Name = "Customer 2",
                    Currency = Currency.Euro,
                    Rating = 112
                },
                new Customer
                {
                    Name = "Jorge",
                    Currency = Currency.Unknown,
                    Rating = 2
                }
            };
        }
    }
}
