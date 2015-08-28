namespace AbstractFactory.BottledWater
{
    using System.Collections.Generic;

    public class TableWater : BottledWater
    {
        private readonly string bottledBy;

        public TableWater(IEnumerable<string> minerals, string botteledBy)
            : base(minerals)
        {
            this.bottledBy = botteledBy;
        }

        protected override string BottledBy
        {
            get
            {
                return string.Format("Table water bottled by {0}", this.bottledBy);
            }
        }
    }
}