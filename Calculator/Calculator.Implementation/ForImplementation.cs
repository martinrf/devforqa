namespace Calculator.Implementation
{
    using System.Collections.Generic;

    public class ForImplementation : BaseImplementation
    {
        protected override void DoAggregation()
        {
            var list = new List<int>(this.Numbers);

            for (var i = 0; i < list.Count; i++)
            {
                Total += list[i];
            }
        }
    }
}
