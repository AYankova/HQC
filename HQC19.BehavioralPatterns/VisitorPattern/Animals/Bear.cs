namespace VisitorPattern.Animals
{
    internal sealed class Bear : Mammal
    {
        public override void Accept(IAnimalVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
