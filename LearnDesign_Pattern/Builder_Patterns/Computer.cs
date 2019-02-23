using System;
using System.Collections.Generic;

namespace LearnDesign_Pattern.Builder_Patterns
{
    internal class Computer
    {
        private readonly IList<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("go...go...go");
            foreach (var part in _parts) Console.WriteLine("In assembly：" + part);
            Console.WriteLine("computer OK");
        }
    }
}