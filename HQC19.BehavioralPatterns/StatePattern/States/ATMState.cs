namespace StatePattern.States
{
    internal abstract class ATMState
    {
        private int dummyCashPresent = 1000;

        public ATM ATM { get; set; }

        public int DummyCashPresent
        {
            get
            {
                return this.dummyCashPresent;
            }

            set
            {
                this.dummyCashPresent = value;
            }
        }

        public abstract string GetNextScreen();
    }
}
