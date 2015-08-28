namespace AbstractFactory
{
    using System;
    using AbstractFactory.Factories;

    public static class AbstractFactoryDemo
    {
        public static void Main()
        {
            var bottleCompany = new PureNaturalInc(); // new SemiNaturalInc();
            var deliveryCompany = new DeliveryCompany(bottleCompany);

            var mineralWater = deliveryCompany.DeliverMineralWater();
            Console.WriteLine(mineralWater.ToString());

            var springWater = deliveryCompany.DeliverSpringWater();
            Console.WriteLine(springWater.ToString());

            var tableWater = deliveryCompany.DeliverTableWater();
            Console.WriteLine(tableWater.ToString());

           // var otherBottleCompany = new SemiNaturalInc();   // var otherBottleCompany=new PureNaturalInc();
           // var otherDeliveryCompany = new DeliveryCompany(otherBottleCompany);

           // var otherMineralWater = otherDeliveryCompany.DeliverMineralWater();
           // Console.WriteLine(otherMineralWater.ToString());

           // var otherSpringWater = otherDeliveryCompany.DeliverSpringWater();
           // Console.WriteLine(otherSpringWater.ToString());

           // var otherTableWater = otherDeliveryCompany.DeliverTableWater();
           // Console.WriteLine(otherTableWater.ToString());
        }
    }
}
