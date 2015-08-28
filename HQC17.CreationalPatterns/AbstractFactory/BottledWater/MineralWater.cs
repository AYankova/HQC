namespace AbstractFactory.BottledWater
{
    using System.Collections.Generic;

    public class MineralWater : BottledWater
    {
        private readonly string bottledBy;

        public MineralWater(IEnumerable<string> minerals, string botteledBy)
            : base(minerals)
        {
            this.bottledBy = botteledBy;
        }

        protected override string BottledBy
        {
            get
            {
                return string.Format("Mineral water bottled by {0}", this.bottledBy);
            }
        }
    }
}
