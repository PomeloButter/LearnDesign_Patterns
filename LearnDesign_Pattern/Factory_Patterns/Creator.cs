using System;
using System.Collections.Generic;
using System.Text;

namespace LearnDesign_Pattern.Factory
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
     abstract class Creator
    {
        //工厂方法
        public abstract Food CreateFoodFactory();
    }
}
