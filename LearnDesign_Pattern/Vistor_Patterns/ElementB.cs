using System;

namespace LearnDesign_Pattern.Vistor_Patterns
{
    public class ElementB:Element
    {
        public override void Accept(IVistor vistor)
        {
            vistor.Visit(this);
        }

        public override void Print()
        {
            Console.WriteLine("我是元素B");
        }
    }
}