namespace Calculator.Implementation
{
    using System.Linq;

    public class UsingLinqImplementation : BaseImplementation
    {
        protected override void DoAggregation()
        {
            this.Total = this.Numbers.Aggregate((x, y) => x + y);
        }
    }
}
