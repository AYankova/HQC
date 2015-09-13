namespace VisitorPattern.Animals
{
    internal sealed class Tiger : Feline
    {
        public override void Accept(IAnimalVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
