namespace OOPSnippets.Inheritance.Single
{
    public class DerivedClass : BaseClass
    {
        public string Name { get; set; }

        public DerivedClass() { }

        public DerivedClass(int id, string name) : base(id)
        {
            this.Name = name;
        }
    }
}
