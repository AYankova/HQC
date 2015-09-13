namespace StatePattern.States
{
    using System;

    internal class CashWithdrawnState : ATMState
    {
        // This constructor will create new state taking values from old state
        public CashWithdrawnState(ATMState state)
            : this(state.DummyCashPresent, state.ATM)
        {
        }

        // this constructor will be used by the other one
        public CashWithdrawnState(int amountRemaining, ATM atmBeingUsed)
        {
            this.ATM = atmBeingUsed;
            this.DummyCashPresent = amountRemaining;
        }

        public override string GetNextScreen()
        {
            this.UpdateState();
            return string.Format("Thanks you for using us, Amount left in ATM: {0}", this.DummyCashPresent.ToString());
        }

        private void UpdateState()
        {
            ATM.CurrentState = new NoCardState(this);
        }
    }
}
