namespace VisitorPattern
{
    using System;
    using System.Collections.Generic;
    using VisitorPattern.Animals;

    internal class ClassicVisitor : IAnimalVisitor
    {
        public void Visit(Animal animal)
        {
            Console.WriteLine(string.Format("{0} was visited just now!", animal.GetType().Name));
        }

        public void VisitAll(IEnumerable<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                animal.Accept(this);
            }
        }
    }
}
