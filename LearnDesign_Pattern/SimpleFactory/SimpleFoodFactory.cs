﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LearnDesigin_Pattern.SimpleFactory
{
    /// <summary>
    /// 简单工厂模式系统难以扩展，一旦添加新产品就不得不修改简单工厂方法，这样就会造成简单工厂的实现逻辑过于复杂
    /// </summary>
    class SimpleFoodFactory
    {
        public static Food CreateFood(string type)
        {
            Food food = null;
            if (type.Equals("A"))
            {
                food=new ShreddedPorkWithPotatoes();
            }
            if (type.Equals("B"))
            {
                food=new TomaoScrambledEggs();
            }
            return food;
        }
    }
}
