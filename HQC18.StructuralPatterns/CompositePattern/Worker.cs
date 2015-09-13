namespace CompositePattern
{
    using System;

    public class Worker : IEmployee
    {
        public Worker(string name, int happiness)
        {
            this.Name = name;
            this.Happiness = happiness;
        }

        public string Name { get; private set; }

        public int Happiness { get; private set; }

        public void ShowHappiness()
        {
            Console.WriteLine(this.Name + " showed happiness level of " + this.Happiness);
        }
    }
}
