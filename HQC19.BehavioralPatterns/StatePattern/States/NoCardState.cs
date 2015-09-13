namespace StatePattern.States
{
    using System;

    internal class NoCardState : ATMState
    {
        // This constructor will create new state taking values from old state
        public NoCardState(ATMState state)
            : this(state.DummyCashPresent, state.ATM)
        {
        }

        // this constructor will be used by the other one
        public NoCardState(int amountRemaining, ATM atmBeingUsed)
        {
            this.ATM = atmBeingUsed;
            this.DummyCashPresent = amountRemaining;
        }

        public override string GetNextScreen()
        {
            Console.WriteLine("Please Enter your Pin");
            string userInput = Console.ReadLine();

            // lets check with the dummy pin
            if (userInput.Trim() == "1234")
            {
                this.UpdateState();
                return "Enter the Amount to Withdraw";
            }

            // Show only message and no change in state
            return "Invalid PIN";
        }

        private void UpdateState()
        {
            ATM.CurrentState = new CardValidatedState(this);
        }
    }
}
