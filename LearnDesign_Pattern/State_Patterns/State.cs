namespace LearnDesign_Pattern.State_Patterns
{
    public abstract class State
    {
        public Account Account { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }
        public double LowerLimit { get; set; }
        public double UpperLimit { get; set; }
        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void PayInterest();
    }
}