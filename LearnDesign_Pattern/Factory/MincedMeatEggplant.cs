using System;
using System.Collections.Generic;
using System.Text;

namespace LearnDesign_Pattern.Factory
{
    /// <summary>
    /// 肉末茄子
    /// </summary>
    class MincedMeatEggplant:Food
    {
        public override void Print()
        {
           Console.WriteLine("MincedMeatEggplant");
        }
    }
}
