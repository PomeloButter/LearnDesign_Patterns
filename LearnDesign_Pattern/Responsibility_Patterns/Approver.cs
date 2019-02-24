namespace LearnDesign_Pattern.Responsibility_Patterns
{
    public abstract class Approver
    {
        public Approver(string name)
        {
            Name = name;
        }

        public Approver NextApprover { get; set; }
        public string Name { get; set; }

        public abstract void ProcessRequest(PurchaseRequest purchaseRequest);
    }
}