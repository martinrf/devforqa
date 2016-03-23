namespace OOPSnippets.Inheritance.Multilevel
{
    public class HomoHabilis
    {
        protected int Speed { get; set; }

        public virtual int Walk()
        {
            this.Speed = 9;
            return this.Speed;
        }
    }
}
