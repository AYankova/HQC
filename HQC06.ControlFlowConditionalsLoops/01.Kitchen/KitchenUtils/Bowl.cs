namespace Kitchen.KitchenUtils
{
    using System.Collections.Generic;
    using Vegetables;

    public class Bowl
    {
        public Bowl()
        {
            this.Products = new List<Vegetable>();
        }

        public IList<Vegetable> Products { get; private set; }

        public void Add(Vegetable vegetable)
        {
            this.Products.Add(vegetable);
        }
    }
}
