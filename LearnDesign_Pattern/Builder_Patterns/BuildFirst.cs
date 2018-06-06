using System;
using System.Collections.Generic;
using System.Text;

namespace LearnDesign_Pattern.Builder_Patterns
{
    class BuildFirst:Builder
    {
         Computer computer=new Computer();
        public override void BuildPartCpu()
        {
           computer.Add("cpu");
        }

        public override void BuildPartMainBoard()
        {
           computer.Add("main board");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
