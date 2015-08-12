namespace Abstraction
{
    using System;

    public class Rectangle : Figure, IFigure
    {
        private const string PropertyNameHeight = "Height";
        private const string PropertyNameWidth = "Width";
        private double width;
        private double height;

        public Rectangle(double width, double height)
            : base()
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                Validator.ValidateValue(value, PropertyNameWidth);
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                Validator.ValidateValue(value, PropertyNameHeight);
                this.height = value;
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalculateArea()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}