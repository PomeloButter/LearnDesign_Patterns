using System;

namespace LearnDesign_Pattern.Responsibility_Patterns
{
    public class Manager:Approver
    {
        public Manager(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest purchaseRequest)
        {
            if (purchaseRequest.Amount < 10000.0)
            {
                Console.WriteLine("{0}-{1} approved the request of purshing {2}", this, Name, purchaseRequest.ProductName);
            }
            else if (NextApprover != null)
            {
                NextApprover.ProcessRequest(purchaseRequest);
            }
        }
    }
}