using System;
using System.Collections.Generic;
using System.Text;

namespace LearnDesign_Pattern.Factory
{
    /// <summary>
    /// 西红柿炒鸡蛋工厂类
    /// </summary>
    class TomatoScrambledEggsFactory : Creator
    {
        public override Food CreateFoodFactory()
        {
            return new TomatoScrambledEggs();
        }
    }
}
