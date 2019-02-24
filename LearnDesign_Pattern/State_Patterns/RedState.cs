using System;

namespace LearnDesign_Pattern.State_Patterns
{
    public class RedState:State
    {
        public RedState(State state)
        {
            this.Balance = state.Balance;
            this.Account = state.Account;
            Interest = 0.00;
            LowerLimit = -100.00;
            UpperLimit = 0.00;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (Balance>UpperLimit)
            {
                Account.State=new SilverState(this);
            }
        }

        public override void Withdraw(double amount)
        {
            Console.WriteLine("没有钱可以取了！");
        }

        public override void PayInterest()
        {
           
        }
    }
}