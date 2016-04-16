namespace Calculator.Implementation
{
    public class DoWhileImplementation : BaseImplementation
    {
        protected override void DoAggregation()
        {
            var enumerator = this.Numbers.GetEnumerator();
            enumerator.MoveNext();
            do
            {
                this.Total += enumerator.Current;
            } while (enumerator.MoveNext());
        }
    }
}
