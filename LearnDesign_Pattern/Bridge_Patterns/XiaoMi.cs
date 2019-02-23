using System;

namespace LearnDesign_Pattern.Bridge_Patterns
{
    public class XiaoMi : Tv
    {
        public override void On()
        {
            Console.WriteLine("小米牌电视机已经打开了");
        }

        public override void Off()
        {
            Console.WriteLine("小米牌电视机已经关掉了");
        }

        public override void TuneChannel()
        {
            Console.WriteLine("小米牌电视机换频道");
        }
    }
}