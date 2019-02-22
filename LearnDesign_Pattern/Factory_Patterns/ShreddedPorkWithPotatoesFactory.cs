using System;
using System.Collections.Generic;
using System.Text;

namespace LearnDesign_Pattern.Factory
{
    /// <summary>
    /// 土豆肉丝工厂类
    /// </summary>
    class ShreddedPorkWithPotatoesFactory : Creator
    {
        public override Food CreateFoodFactory()
        {
            return new ShreddedPorkWithPotatoes();
        }
    }
}
