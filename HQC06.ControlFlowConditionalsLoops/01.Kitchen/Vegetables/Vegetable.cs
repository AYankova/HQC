namespace Kitchen.Vegetables
{
    public abstract class Vegetable
    {
        public Vegetable()
        {
            this.IsCut = false;
            this.IsPeeled = false;
        }

        public bool IsCut { get; protected set; }

        public bool IsPeeled { get; protected set; }

        public void Cut()
        {
            this.IsCut = true;
        }

        public void Peel()
        {
            this.IsPeeled = true;
        }
    }
}
