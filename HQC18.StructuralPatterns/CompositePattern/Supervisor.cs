namespace CompositePattern
{
    using System;
    using System.Collections.Generic;

    public class Supervisor : IEmployee
    {
        private readonly List<IEmployee> subordinates = new List<IEmployee>();

        public Supervisor(string name, int happiness)
        {
            this.Name = name;
            this.Happiness = happiness;
        }

        public string Name { get; private set; }

        public int Happiness { get; private set; }

        public void ShowHappiness()
        {
            Console.WriteLine(this.Name + " showed happiness level of " + this.Happiness);

            foreach (var p in this.subordinates)
            {
                p.ShowHappiness();
            }
        }

        public void AddSubordinate(IEmployee employee)
        {
            this.subordinates.Add(employee);
        }
    }
}
