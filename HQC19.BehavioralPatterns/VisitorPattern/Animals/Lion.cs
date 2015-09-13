namespace VisitorPattern.Animals
{
    internal sealed class Lion : Feline
    {
        public override void Accept(IAnimalVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
