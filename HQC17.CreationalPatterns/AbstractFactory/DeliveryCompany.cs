namespace AbstractFactory
{
    using AbstractFactory.BottledWater;
    using AbstractFactory.Factories;

    public class DeliveryCompany
    {
        private readonly AbstractBottledWaterFactory factory;

        public DeliveryCompany(AbstractBottledWaterFactory bottledWaterFactory)
        {
            this.factory = bottledWaterFactory;
        }

        public MineralWater DeliverMineralWater()
        {
            return this.factory.BottleMineralWater();
        }

        public TableWater DeliverTableWater()
        {
            return this.factory.BottleTableWater();
        }

        public SpringWater DeliverSpringWater()
        {
            return this.factory.BottleSpringrWater();
        }
    }
}
