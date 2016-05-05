namespace HowToLinq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Queries
    {
        private ICollection<Property> _properties;

        [TestInitialize]
        public void Setup()
        {
            this.InitializeProperties();
        }

        [TestMethod]
        public void PartsOfQuery()
        {
            // The Three Parts of a LINQ Query:
            //  1. Data source.
            var numbers = new[] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers 
                where (num % 2) == 0
                select num;
            
            var result = new StringBuilder();

            // 3. Query execution.
            foreach (var num in numQuery)
            {
                result.Append($"{num,1}|");
            }

            Assert.AreEqual("0|2|4|6|", result.ToString());
        }

        public IEnumerable<Property> From()
        {
            var query = from property in this._properties
                        select property;
            return query;
        }

        public IEnumerable<Property> Where()
        {
            var query = from property in this._properties
                        where property.Currency == Currency.Dollar
                        select property;
            return query;
        }

        public IEnumerable<Property> WhereAnd()
        {
            var query = from property in this._properties
                        where property.Currency == Currency.Dollar && property.Rating >= 3
                        select property;
            return query;
        }

        public IEnumerable<Property> WhereOr()
        {
            var query = from property in this._properties
                        where property.Currency == Currency.Dollar || property.Rating <= 3
                        select property;
            return query;
        }

        public IEnumerable<Property> Ordering()
        {
            var query = from property in this._properties
                        where property.Currency == Currency.Dollar
                        orderby property.Rating ascending 
                        select property;
            return query;
        }

        public IEnumerable<IGrouping<Currency, Property>> Grouping()
        {
            var query = from property in this._properties
                        group property by property.Currency;
            return query;
        }

        [TestMethod]
        public void GroupingTest()
        {
            foreach (var propertyGroup in this.Grouping())
            {
                foreach (var property in propertyGroup)
                {
                    Assert.AreEqual(propertyGroup.Key, property.Currency);
                }
            }
        }

        private void InitializeProperties()
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
        }
    }
}
