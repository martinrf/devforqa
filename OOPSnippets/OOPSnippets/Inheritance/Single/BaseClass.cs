namespace OOPSnippets.Inheritance.Single
{
    public class BaseClass
    {
        public int Id { get; private set; }
        
        public BaseClass() { }

        public BaseClass(int id)
        {
            this.Id = id;
        }
    }
}
