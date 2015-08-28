namespace AbstractFactory.Factories
{
    using System.Collections.Generic;
    using AbstractFactory.BottledWater;

    public class PureNaturalInc : AbstractBottledWaterFactory
    {
        private const string CompanyName = "PureNaturalInc";

        public override MineralWater BottleMineralWater()
        {
            var minerals = new List<string>() { "Ca++", "Mg++", "Cl-" };

            return new MineralWater(minerals, CompanyName);
        }

        public override SpringWater BottleSpringrWater()
        {
            var minerals = new List<string>() { "Ca++", "Mg++", "HCO3-", "Na+", "Cl-" };

            return new SpringWater(minerals, CompanyName);
        }

        public override TableWater BottleTableWater()
        {
            var minerals = new List<string>() { "Ca++", "Na+" };

            return new TableWater(minerals, CompanyName);
        }
    }
}
