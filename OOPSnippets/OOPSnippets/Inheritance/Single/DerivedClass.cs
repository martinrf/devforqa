namespace OOPSnippets.Inheritance.Single
{
    public class DerivedClass : BaseClass
    {
        public string Name { get; private set; }

        public DerivedClass() { }

        public DerivedClass(int id, string name) : base(id)
        {
            this.Name = name;
        }
    }
}
