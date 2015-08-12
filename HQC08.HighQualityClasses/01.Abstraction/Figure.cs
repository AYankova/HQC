namespace Abstraction
{
    using System;
    using System.Text;

    public abstract class Figure : IFigure
    {
        protected Figure()
        {
        }

        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("I am a {0}. My perimeter is {1:f2}. My surface is {2:f2}.", this.GetType().Name.ToLower(), this.CalculatePerimeter(), this.CalculateArea());

            return result.ToString();
        }
    }
}