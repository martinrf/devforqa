namespace HowToLinq
{
    using System;

    public struct Property
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public decimal SalePrice { get; set; }
        public Currency Currency { get; set; }
        public DateTime DateInMarket { get; set; }
    }

    public struct Customer
    {
        public string Name { get; set; }
        public Currency Currency  { get; set; }
        public int Rating { get; set; }
    }

    public enum Currency
    {
        Unknown = 0,
        Dollar = 1,
        Euro = 2
    }
}
