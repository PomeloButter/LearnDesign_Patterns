using System;

namespace LearnDesign_Pattern.Decorator_Patterns
{
    public class ApplePhone : Phone
    {
        public override void Print()
        {
            Console.WriteLine("apple phone");
        }
    }
}