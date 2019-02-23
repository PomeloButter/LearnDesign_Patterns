using System;

namespace LearnDesign_Pattern.Proxy_Patterns
{
    public class RealBuyPerson : Person
    {
        public override void BuyProduct()
        {
            Console.WriteLine("帮我买一个IPhone和一台苹果电脑");
        }
    }
}