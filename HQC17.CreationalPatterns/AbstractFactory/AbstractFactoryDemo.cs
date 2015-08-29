namespace AbstractFactory
{
    using System;
    using AbstractFactory.Factories;

    public static class AbstractFactoryDemo
    {
        public static void Main()
        {
            var bottleCompany = new PureNaturalInc(); // var bottleCompany = new SemiNaturalInc();
            var deliveryCompany = new DeliveryCompany(bottleCompany);

            var mineralWater = deliveryCompany.DeliverMineralWater();
            Console.WriteLine(mineralWater.ToString());

            var springWater = deliveryCompany.DeliverSpringWater();
            Console.WriteLine(springWater.ToString());

            var tableWater = deliveryCompany.DeliverTableWater();
            Console.WriteLine(tableWater.ToString());
        }
    }
}
