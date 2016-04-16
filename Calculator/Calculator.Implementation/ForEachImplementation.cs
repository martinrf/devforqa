namespace Calculator.Implementation
{
    public class ForEachImplementation : BaseImplementation
    {
        protected override void DoAggregation()
        {
            foreach (var number in this.Numbers)
            {
                this.Total += number;
            }
        }
    }
}
