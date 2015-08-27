namespace SingletonPattern
{
    using System;
    using System.Collections.Generic;

    public sealed class LazyThreadSafeStore
    {
        private static readonly Lazy<LazyThreadSafeStore> Lazy =
            new Lazy<LazyThreadSafeStore>(() => new LazyThreadSafeStore());

        private readonly List<Item> items;

        private LazyThreadSafeStore()
        {
            this.items = new List<Item>();
        }

        public static LazyThreadSafeStore Instance
        {
            get
            {
                return Lazy.Value;
            }
        }

        public void AddItem(Item item)
        {
            this.items.Add(item);
        }

        public void PrintItems()
        {
            Console.WriteLine("Items in store:");

            foreach (var item in this.items)
            {
                Console.WriteLine(string.Format("Type: {0}", item.Type));
                Console.WriteLine(string.Format("Brand: {0}", item.Brand));
                Console.WriteLine(string.Format("Quantity: {0}", item.Quantity));
            }
        }
    }
}
