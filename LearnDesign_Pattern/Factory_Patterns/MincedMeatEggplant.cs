using System;

namespace LearnDesign_Pattern.Factory_Patterns
{
    /// <summary>
    ///     肉末茄子
    /// </summary>
    internal class MincedMeatEggplant : Food
    {
        public override void Print()
        {
            Console.WriteLine("MincedMeatEggplant");
        }
    }
}