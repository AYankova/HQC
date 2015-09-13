namespace VisitorPattern.Animals
{
    internal sealed class Snake : Reptile
    {
        public override void Accept(IAnimalVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
