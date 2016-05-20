namespace HowToLinq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
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

        public IEnumerable<Customer> AllCustomers()
        {
            return this._customers.Select(x => x);
        }

        public IEnumerable<Property> AllProperties()
        {
            return this._properties.Select(x => x);
        }

        [TestMethod]
        public void SelectingItems()
        {
            var a = new List<string>();

            var b = from p in this._properties select p;
            IEnumerable<Property> asa = from p in this._properties select p;

            var c = from p in this._properties select p.Name;
            IEnumerable<string> dadç = from p in this._properties select p.Name;


            var d = from p in this._properties select new { p.Rating, p.Name };
            IEnumerable<object> ds = from p in this._properties select new { p.Rating, p.Name };

            var f = from p in this._properties select new Property { Rating = p.Rating, Name = p.Name };
            IEnumerable<Property> fs = from p in this._properties select new Property { Rating = p.Rating, Name = p.Name };

            var f1 = from p in this._properties select new ItemList { MagicNumber = p.Rating, Name = p.Name };

        }

        [TestMethod]
        public void PropertiesAndCustomersByCurrencyTest()
        {
            foreach (var group in PropertiesAndCustomersByCurrency())
            {
                foreach (var hasCurrency in group)
                {
                    Assert.AreEqual(hasCurrency.Currency, group.Key);
                }
            }
        }

        [TestMethod]
        public void AvgPriceByCurrency()
        {
            var result = this.GetAveragePropertyPrice();
            Assert.AreEqual(175483m, result[Currency.Dollar]);
            Assert.AreEqual(75499.5m, result[Currency.Euro]);
        }

        [TestMethod]
        public void AveragePropertyPriceByCurrency()
        {
            var result = AveragePriceByCurrency();
            Assert.AreEqual(175483m, result[Currency.Dollar]);
            Assert.AreEqual(75499.5m, result[Currency.Euro]);
        }

        public IDictionary<Currency, decimal> GetAveragePropertyPrice()
        {
            /*
            1. Calcular el costo promedio de las propiedades por moneda
            2. Agrupar por moneda
            3. Sumar el precio.
            4. Dividir entre el total de properties para esa moneda.
            5. retornar el diccionario en cuestion
            */
            var property = new Property
            {
                DateInMarket = DateTime.MaxValue,
                Rating = 12,
                SalePrice = 223123423m
            };

            var q1 = from p in this._properties
                     group p by new { p.Currency } into g
                     select new
                     {
                         Average = g.Average(p => p.SalePrice),
                         g.Key.Currency
                     };

            return null;
        }

        public IDictionary<Currency, decimal> AveragePriceByCurrency()
        {
            var query = from p in this._properties
                        group p by new
                        {
                            p.Currency
                        }
                into g
                        select new
                        {
                            Average = g.Average(p => p.SalePrice),
                            g.Key.Currency
                        };

            return query.ToDictionary(x => x.Currency, x => x.Average);
        }

        public IEnumerable<IGrouping<Currency, IHasCurrency>> PropertiesAndCustomersByCurrency()
        {
            var mergeList = this._properties.Cast<IHasCurrency>().Concat(this._customers.Cast<IHasCurrency>());
            var query = from item in mergeList
                        group item by item.Currency;
            return query;
        }

        private void InitializeEntities()
        {
            this._properties = new List<Property>
            {
                new Property
                {
                    Name = "Property Dollar 1",
                    DateInMarket = new DateTime(2016, 1, 12),
                    Rating = 2,
                    SalePrice = 325465m,
                    Currency = Currency.Dollar
                },
                new Property
                {
                    Name = "Property Dollar 2",
                    DateInMarket = new DateTime(2016, 3, 6),
                    Rating = 4,
                    SalePrice = 225468m,
                    Currency = Currency.Dollar
                },
                new Property
                {
                    Name = "Property Dollar 3",
                    DateInMarket = new DateTime(2016, 2, 9),
                    Rating = 3,
                    SalePrice = 117755m,
                    Currency = Currency.Dollar
                },
                new Property
                {
                    Name = "Property Dollar 4",
                    DateInMarket = new DateTime(2016, 2, 11),
                    Rating = 3,
                    SalePrice = 33244m,
                    Currency = Currency.Dollar
                },
                new Property
                {
                    Name = "Property Euro 3",
                    DateInMarket = new DateTime(2016, 2, 9),
                    Rating = 3,
                    SalePrice = 117755m,
                    Currency = Currency.Euro
                },
                new Property
                {
                    Name = "Property Euro 4",
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
                    Name = "Customer Euro 1",
                    Currency = Currency.Euro,
                    Rating = 59
                },
                new Customer
                {
                    Name = "Customer Euro 2",
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

        [TestMethod]
        public void NamesByCurrency()
        {
            var queryProperties = from p in this._properties select new { p.Name, p.Currency };
            var queryCustomer = from p in this._customers select new { p.Name, p.Currency };
            var merged = queryProperties.Concat(queryCustomer);
            var queryResult = from item in merged group item.Name by item.Currency;
            var queryResult2 = merged.GroupBy(x => x.Currency, x => x.Name);
            Assert.AreEqual(true, false);
        }

        public void NameAndCurrency()
        {
            var queryCustomer = from p in this._customers select new { p.Name, p.Currency };
            var queryCustomer2 = this._customers.Select(x => new { x.Name,  x.Currency});
        }  
    }
    public class ItemList
    {
        public string Name { get; set; }
        public int MagicNumber { get; set; }
    }
}
