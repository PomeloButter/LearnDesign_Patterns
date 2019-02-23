using System;

namespace LearnDesign_Pattern.Bridge_Patterns
{
    public class Samsung : Tv
    {
        public override void On()
        {
            Console.WriteLine("三星牌电视机已经打开了");
        }

        public override void Off()
        {
            Console.WriteLine("三星牌电视机已经关掉了");
        }

        public override void TuneChannel()
        {
            Console.WriteLine("三星牌电视机换频道");
        }
    }
}