namespace AbstractFactory.BottledWater
{
    using System.Collections.Generic;

    public class SpringWater : BottledWater
    {
        private readonly string bottledBy;

        public SpringWater(IEnumerable<string> minerals, string botteledBy)
            : base(minerals)
        {
            this.bottledBy = botteledBy;
        }

        protected override string BottledBy
        {
            get
            {
                return string.Format("Spring water bottled by {0}", this.bottledBy);
            }
        }
    }
}