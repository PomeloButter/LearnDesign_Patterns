using System;
using System.Collections.Generic;
using System.Text;

namespace LearnDesign_Pattern.Builder_Patterns
{
    class BuildSecond:Builder
    {
        Computer computer=new Computer();
        public override void BuildPartCpu()
        {
           computer.Add("Cpu A");
        }

        public override void BuildPartMainBoard()
        {
            computer.Add("MainBoard A");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
