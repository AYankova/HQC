namespace CompositePattern
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Worker tom = new Worker("Worker Tom", 0);
            Supervisor mary = new Supervisor("Supervisor Mary", 50);
            Supervisor jerry = new Supervisor("Supervisor Jerry", 100);
            Supervisor bob = new Supervisor("Supervisor Bob", 50);
            Worker jimmy = new Worker("Worker Jimmy", 0);

            // set up the relationships
            mary.AddSubordinate(tom); // Tom works for Mary
            jerry.AddSubordinate(mary); // Mary works for Jerry
            jerry.AddSubordinate(bob); // Bob works for Jerry
            bob.AddSubordinate(jimmy); // Jimmy works for Bob

            // Jerry shows his happiness and asks everyone else to do the same
            jerry.ShowHappiness();
        }
    }
}
