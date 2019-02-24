namespace LearnDesign_Pattern.Responsibility_Patterns
{
    public class PurchaseRequest
    {
        public PurchaseRequest(double amount, string productName)
        {
            Amount = amount;
            ProductName = productName;
        }

        public double Amount { get; set; }
        public  string ProductName { get; set; }

    }
}