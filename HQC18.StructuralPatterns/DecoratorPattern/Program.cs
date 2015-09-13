namespace DecoratorPattern
{
    using System;
    using DecoratorPattern.Bakeries;
    using DecoratorPattern.Decorations;

    public class Program
    {
        public static void Main()
        {
            // Let us create a Simple Cake Base first
            CakeBase cakeBase = new CakeBase();
            PrintProductDetails(cakeBase);

            // Lets add cream to the cake
            CreamDecorator creamCake = new CreamDecorator(cakeBase);
            PrintProductDetails(creamCake);

            // Let now add a Cherry on it
            CherryDecorator cherryCake = new CherryDecorator(creamCake);
            PrintProductDetails(cherryCake);

            // Lets now add Scent to it
            ArtificialScentDecorator scentedCake = new ArtificialScentDecorator(cherryCake);
            PrintProductDetails(scentedCake);

            // Finally add a Name card on the cake
            NameCardDecorator nameCardOnCake = new NameCardDecorator(scentedCake);
            PrintProductDetails(nameCardOnCake);

            // Lets now create a simple Pastry
            PastryBase pastry = new PastryBase();
            PrintProductDetails(pastry);

            // Lets just add cream and cherry only on the pastry 
            CreamDecorator creamPastry = new CreamDecorator(pastry);
            CherryDecorator cherryPastry = new CherryDecorator(creamPastry);
            PrintProductDetails(cherryPastry);
        }

        private static void PrintProductDetails(BakeryComponent bakeryComponent)
        {
            Console.WriteLine(string.Format("Item: {0} --> Price: {1}", bakeryComponent.GetName(), bakeryComponent.GetPrice()));
        }
    }
}
