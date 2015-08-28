namespace AbstractFactory.Factories
{
    using AbstractFactory.BottledWater;

    public abstract class AbstractBottledWaterFactory
    {
        public abstract MineralWater BottleMineralWater();

        public abstract SpringWater BottleSpringrWater();

        public abstract TableWater BottleTableWater();
    }
}
