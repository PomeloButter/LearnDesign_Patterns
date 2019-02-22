using System;
using System.Collections.Generic;
using System.Text;

namespace LearnDesign_Pattern.Factory
{
    class MincedMeatEggplantFactory:Creator
    {
        public override Food CreateFoodFactory()
        {
          return  new MincedMeatEggplant();
        }
    }
}
