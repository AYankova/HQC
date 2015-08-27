namespace SingletonPattern
{
    using System;

    public class Item
    {
        public Item(string type, string brand, int quantity)
        {
            this.Type = type;
            this.Brand = brand;
            this.Quantity = quantity;
        }

        public string Type { get; private set; }

        public string Brand { get; private set; }

        public int Quantity { get; private set; }
    }
}
