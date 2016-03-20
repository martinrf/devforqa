using OOPSnippets.Polymorphism.Models;

namespace OOPSnippets.Polymorphism
{
    public class PropertyHeaderFormatter : HeaderFormatter
    {
        public PropertyHeaderFormatter(HeaderModel model) : base(model)
        {
            this.Entity = model;
        }

        public override string LineTwo
        {
            get { return $"Property Name: {this.Entity.PropertyName}"; }
        }
    }
}