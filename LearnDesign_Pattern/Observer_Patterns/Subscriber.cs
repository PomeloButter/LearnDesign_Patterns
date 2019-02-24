using System;

namespace LearnDesign_Pattern.Observer_Patterns
{
    public class Subscriber:IObserver
    {
        public string Name { get; set; }

        public Subscriber(string name)
        {
            Name = name;
        }

        public void Receive(TenXun tenXun)
        {
            Console.WriteLine("Notified {0} of {1}'s" + " Info is: {2}", Name, tenXun.Symbol, tenXun.Info);
        }
    }
}