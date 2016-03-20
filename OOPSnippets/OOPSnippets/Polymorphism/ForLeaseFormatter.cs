using OOPSnippets.Polymorphism.Models;

namespace OOPSnippets.Polymorphism
{
    public class ForLeaseFormatter : HeaderFormatter
    {
        public ForLeaseFormatter(HeaderModel model) : base(model)
        {
        }

        public override string LineOne
        {
            get { return $"For Lease Price: {this.Entity.Price}"; }
        }
    }
}
