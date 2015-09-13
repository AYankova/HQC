namespace DecoratorPattern.Decorations
{
    using System;
    using DecoratorPattern.Bakeries;

    internal abstract class Decorator : BakeryComponent
    {
        protected Decorator(BakeryComponent baseComponent)
        {
            this.BaseComponent = baseComponent;
        }

        protected string DecoratorName { get; set; }

        protected double Price { get; set; }

        private BakeryComponent BaseComponent { get; set; }

        public override string GetName()
        {
            return string.Format("{0}, {1}", this.BaseComponent.GetName(), this.DecoratorName);
        }

        public override double GetPrice()
        {
            return this.Price + this.BaseComponent.GetPrice();
        }
    }
}
