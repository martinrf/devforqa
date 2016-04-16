namespace Calculator.Implementation
{
    public class WhileImplementation : BaseImplementation
    {
        protected override void DoAggregation()
        {
            var enumerator = this.Numbers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                this.Total += enumerator.Current;
            }
        }
    }
}
