using System.Collections.Generic;

namespace LearnDesign_Pattern.Observer_Patterns
{
    public class TenXun
    {
        private List<IObserver> observers=new List<IObserver>();
       
        public TenXun(string info, string symbol)
        {
            Info = info;
            Symbol = symbol;
        }

        public string Symbol { get; set; }
        public string Info { get; set; }


        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Update()
        {
            foreach (var item in observers)
            {
                item?.Receive(this);
            }
        }
    }
}