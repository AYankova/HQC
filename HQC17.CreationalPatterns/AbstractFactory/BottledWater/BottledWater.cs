namespace AbstractFactory.BottledWater
{
    using System.Collections.Generic;
    using System.Text;

    public abstract class BottledWater
    {
        private readonly IReadOnlyCollection<string> minerals;

        protected BottledWater(IEnumerable<string> minerals)
        {
            this.minerals = new List<string>(minerals);
        }

        protected abstract string BottledBy { get; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(this.BottledBy);
            result.AppendLine(string.Join(", ", this.minerals));

            return result.ToString();
        }
    }
}
