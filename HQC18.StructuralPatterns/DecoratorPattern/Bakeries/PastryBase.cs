namespace DecoratorPattern.Bakeries
{
    internal class PastryBase : BakeryComponent
    {
        private readonly string pastryName = "Pastry base";
        private readonly double price = 20.0;

        public override string GetName()
        {
            return this.pastryName;
        }

        public override double GetPrice()
        {
            return this.price;
        }
    }
}
