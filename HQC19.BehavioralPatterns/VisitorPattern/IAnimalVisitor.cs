namespace VisitorPattern
{
    using System;
    using System.Linq;
    using VisitorPattern.Animals;

    internal interface IAnimalVisitor
    {
        void Visit(Animal bear);
    }
}
