namespace DecoratorPattern.Decorations
{
    using DecoratorPattern.Bakeries;

    internal class CreamDecorator : Decorator
    {
        public CreamDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            this.DecoratorName = "Cream";
            this.Price = 1.0;
        }
    }
}
