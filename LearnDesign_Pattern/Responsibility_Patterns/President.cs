using System;

namespace LearnDesign_Pattern.Responsibility_Patterns
{
    public class President:Approver
    {
        public President(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest purchaseRequest)
        {
            if (purchaseRequest.Amount < 100000.0)
            {
                Console.WriteLine("{0}-{1} approved the request of purshing {2}", this, Name, purchaseRequest.ProductName);
            }
            else
            {
                Console.WriteLine("Request需要组织一个会议讨论");
            }
        }
    }
}