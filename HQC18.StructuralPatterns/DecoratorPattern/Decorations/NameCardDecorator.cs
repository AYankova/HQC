namespace DecoratorPattern.Decorations
{
    using System;
    using DecoratorPattern.Bakeries;

    internal class NameCardDecorator : Decorator
    {
        private readonly int discountRate = 5;

        public NameCardDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            this.DecoratorName = "Name Card";
            this.Price = 4.0;
        }

        public override string GetName()
        {
            return base.GetName() +
                string.Format("\n(Please Collect your discount card for {0}%)", this.discountRate);
        }
    }
}
