namespace OOPSnippets.Inheritance.Multilevel
{
    public class HomoNeanderthalensis : HomoErectus
    {        
        public override int Walk()
        {
            this.Speed = 11;
            return this.Speed;
        }
    }
}
