namespace DecoratorPattern.Bakeries
{
    internal class CakeBase : BakeryComponent
    {
        private readonly string cakeName = "Cake base";
        private readonly double price = 200.0;

        public override string GetName()
        {
            return this.cakeName;
        }

        public override double GetPrice()
        {
            return this.price;
        }
    }
}
