using System;

namespace LearnDesign_Pattern.Bridge_Patterns
{
    public class ConcreteRemote:RemoteControl
    {
        public override void SetChannel()
        {
            Console.WriteLine("-----------------");
            base.SetChannel();
            Console.WriteLine("-----------------");
        }
    }
}