namespace Calculator.Implementation
{
    using System;
    using System.Linq;

    public class UsingLinqImplementation : BaseImplementation
    {
        protected override void DoAggregation()
        {
            this.Total = this.Numbers.Aggregate((x, y) => x + y);

            var suma = new Func<int, int, int>((x, y) => x + y);
            this.Total = this.Numbers.Aggregate(suma);
            
            this.Total = this.Numbers.Aggregate(this.Suma);
        }

        public int Suma(int x, int y)
        {
            return x + y;
        }
    }
}
