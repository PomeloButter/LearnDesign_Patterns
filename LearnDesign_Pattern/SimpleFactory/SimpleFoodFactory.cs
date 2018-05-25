using System;
using System.Collections.Generic;
using System.Text;

namespace LearnDesigin_Pattern.SimpleFactory
{
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
