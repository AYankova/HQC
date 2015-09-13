namespace FacadePattern
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            MyJoggingFacade facade = new MyJoggingFacade();

            Console.WriteLine("***  Jog Using Facade  ***");
            facade.StartJogging();
            Console.WriteLine();
            facade.StopJogging();
        }
    }
}
