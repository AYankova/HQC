namespace SingletonPattern
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class StoreDemo
    {
        public static void Main()
        {
            var store = LazyThreadSafeStore.Instance;
            var jeans = new Item("jeans", "CK", 5);
            var tshirts = new Item("t-shirt", "Gap", 11);
            var store2 = LazyThreadSafeStore.Instance;
            var watches = new Item("watch", "Tissot", 2);

            store.AddItem(jeans);
            store.AddItem(tshirts);
            store2.AddItem(watches);

            store.PrintItems();

            // Parallel.For(0, 6, x => { LazyThreadSafeStore.Instance.AddItem(new Item(x.ToString(), x.ToString(), x)); });
            // LazyThreadSafeStore.Instance.PrintItems();
        }
    }
}
