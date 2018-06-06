using System;
using System.Collections.Generic;
using System.Text;

namespace LearnDesign_Pattern.Builder_Patterns
{
    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartCpu();
            builder.BuildPartMainBoard();
        }
    }
}
