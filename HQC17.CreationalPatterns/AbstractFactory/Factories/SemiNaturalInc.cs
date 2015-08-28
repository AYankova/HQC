namespace AbstractFactory.Factories
{
    using System.Collections.Generic;
    using AbstractFactory.BottledWater;

    public class SemiNaturalInc : AbstractBottledWaterFactory
    {
        private const string CompanyName = "SemiNaturalInc";

        public override MineralWater BottleMineralWater()
        {
            var minerals = new List<string>() { "As-", "Ra+", "Cl-" };

            return new MineralWater(minerals, CompanyName);
        }

        public override SpringWater BottleSpringrWater()
        {
            var minerals = new List<string>() { "Au+", "Pt-", "O2-" };

            return new SpringWater(minerals, CompanyName);
        }

        public override TableWater BottleTableWater()
        {
            var minerals = new List<string>() { "Hg+" };

            return new TableWater(minerals, CompanyName);
        }
    }
}
