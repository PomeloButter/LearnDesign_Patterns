using System;

namespace LearnDesign_Pattern.State_Patterns
{
    public class Account
    {
        public Account(string owner)
        {
            Owner = owner;
            State = new SilverState(0.0, this);
        }

        public State State { get; set; }
        public string Owner { get; set; }
        public double Balance { get { return State.Balance; } }

        public void Deposit(double amount)
        {
            State.Deposit(amount);
            Console.WriteLine("存款金额为 {0:C}——", amount);
            Console.WriteLine("账户余额为 =:{0:C}", this.Balance);

            Console.WriteLine("账户状态为: {0}", this.State.GetType().Name);
            Console.WriteLine();
        }

        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
            Console.WriteLine("取款金额为 {0:C}——", amount);
            Console.WriteLine("账户余额为 =:{0:C}", this.Balance);
            Console.WriteLine("账户状态为: {0}", this.State.GetType().Name);
            Console.WriteLine();
        }

        public void PayInterest()
        {
            State.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine("账户余额为 =:{0:C}", this.Balance);
            Console.WriteLine("账户状态为: {0}", this.State.GetType().Name);
            Console.WriteLine();
        }
    }
}