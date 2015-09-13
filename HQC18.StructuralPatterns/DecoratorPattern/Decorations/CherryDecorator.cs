namespace DecoratorPattern.Decorations
{
    using DecoratorPattern.Bakeries;

    internal class CherryDecorator : Decorator
    {
        public CherryDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            this.DecoratorName = "Cherry";
            this.Price = 2.0;
        }
    }
}
