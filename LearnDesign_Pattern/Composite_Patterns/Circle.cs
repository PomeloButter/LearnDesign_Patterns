using System;

namespace LearnDesign_Pattern.Composite_Patterns
{
    public class Circle:Graphics
    {
        public Circle(string name) : base(name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("画  " + Name);
        }
    }
}