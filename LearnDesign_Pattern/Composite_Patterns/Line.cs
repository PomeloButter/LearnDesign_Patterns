using System;

namespace LearnDesign_Pattern.Composite_Patterns
{
    public class Line : Graphics
    {
        public Line(string name) : base(name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("画  " + Name);
        }
    }
}