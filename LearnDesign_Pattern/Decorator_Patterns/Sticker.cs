using System;

namespace LearnDesign_Pattern.Decorator_Patterns
{
    public class Sticker : Decorator
    {
        public Sticker(Phone phone) : base(phone)
        {
        }

        public override void Print()
        {
            base.Print();
            AddSticker();
        }

        public void AddSticker()
        {
            Console.WriteLine("现在手机贴膜了");
        }
    }
}