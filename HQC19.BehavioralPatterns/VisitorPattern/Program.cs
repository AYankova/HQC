namespace VisitorPattern
{
    using System;
    using System.Collections.Generic;
    using VisitorPattern.Animals;

    public class Program
    {
        public static void Main()
        {
            var visitor = new ClassicVisitor();
            var bear = new Bear();

            visitor.Visit(bear);

            Console.WriteLine("**************");

            var animals = new List<Animal>() { new Lion(), new Tiger(), new Snake(), new Bear() };

            visitor.VisitAll(animals);
        }
    }
}
