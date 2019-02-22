using System;
using System.Collections.Generic;
using System.Text;

namespace LearnDesign_Pattern.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract YaBo CreateYaBo();
        public abstract YaJia CreateYaJia();

    }
}
