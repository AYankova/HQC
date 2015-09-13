namespace StatePattern
{
    using System;
    using StatePattern.States;

    internal class ATM
    {
        public ATM()
        {
            this.CurrentState = new NoCardState(1000, this);
        }

        public ATMState CurrentState { get; set; }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine(this.CurrentState.GetNextScreen());
            }
        }
    }
}
