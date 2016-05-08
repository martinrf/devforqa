namespace HowToLinq
{
    using System;

    public interface IHasCurrency
    {
        Currency Currency { get; set; }
    }

    public struct Property : IHasCurrency
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public decimal SalePrice { get; set; }
        public Currency Currency { get; set; }
        public DateTime DateInMarket { get; set; }
    }

    public struct Customer : IHasCurrency
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
