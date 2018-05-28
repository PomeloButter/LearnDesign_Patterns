using System;
using System.Collections.Generic;
using System.Text;

namespace LearnDesign_Pattern.AbstractFactory
{
    class HuNanFactory:AbstractFactory
    {
        public override YaBo CreateYaBo()=>new HuNanYaBo();

        public override YaJia CreateYaJia() =>new HuNanYaJia();
    }
}
