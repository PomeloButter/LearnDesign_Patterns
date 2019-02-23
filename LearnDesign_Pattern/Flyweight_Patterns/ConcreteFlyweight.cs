using System;

namespace LearnDesign_Pattern.Flyweight_Patterns
{
    public class ConcreteFlyweight : Flyweight
    {
        private readonly string intrinsicstate;

        public ConcreteFlyweight(string intrinsicstate)
        {
            this.intrinsicstate = intrinsicstate;
        }

        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("具体实现类: intrinsicstate {0}, extrinsicstate {1}", intrinsicstate, extrinsicstate);
        }
    }
}