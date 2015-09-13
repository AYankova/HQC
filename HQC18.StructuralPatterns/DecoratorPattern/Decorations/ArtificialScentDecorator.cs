namespace DecoratorPattern.Decorations
{
    using DecoratorPattern.Bakeries;

    internal class ArtificialScentDecorator : Decorator
    {
        public ArtificialScentDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            this.DecoratorName = "Artificial Scent";
            this.Price = 3.0;
        }
    }
}
