namespace RefactoringIfs
{
    public class Potato
    {
        public Potato()
        {
        }

        public bool IsPeeled { get; private set; }

        public bool IsRotten { get; private set; }

        public bool IsCooked { get; private set; }

        public void Cook()
        {
            this.IsCooked = true;
        }
    }
}
