using OOPSnippets.Polymorphism.Models;

namespace OOPSnippets.Polymorphism
{
    public class ForSaleHeaderFormatter : HeaderFormatter
    {
        public ForSaleHeaderFormatter(HeaderModel model) : base(model)
        {
        }

        public override string LineOne
        {
            get { return $"For Sale Price: {this.Entity.Price}"; }
        }
    }
}