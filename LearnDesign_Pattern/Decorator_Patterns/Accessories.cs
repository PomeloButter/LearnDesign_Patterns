using System;

namespace LearnDesign_Pattern.Decorator_Patterns
{
    public class Accessories:Decorator
    {
        public Accessories(Phone phone) : base(phone)
        {
        }

        public override void Print()
        {
            base.Print();
            AddAccessories();
        }

        public void AddAccessories()
        {
            Console.WriteLine("手机又挂件了");
        }
    }
}