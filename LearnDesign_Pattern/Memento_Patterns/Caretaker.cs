using System.Collections.Generic;

namespace LearnDesign_Pattern.Memento_Patterns
{
    public class Caretaker
    {
        public Dictionary<string, ContactMemento> ContactMementoDic { get; set; }
        public Caretaker()
        {
            ContactMementoDic = new Dictionary<string, ContactMemento>();
        }
    }
}