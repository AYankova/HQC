namespace VisitorPattern.Animals
{
    internal abstract class Animal
    {
        public abstract void Accept(IAnimalVisitor visitor);
    }
}
