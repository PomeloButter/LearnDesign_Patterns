using System.Collections.Generic;

namespace LearnDesign_Pattern.Memento_Patterns
{
    public class ContactMemento
    {
        public ContactMemento(List<ContactPerson> contactPersonBack)
        {
            ContactPersonBack = contactPersonBack;
        }

        public List<ContactPerson> ContactPersonBack { get; set; }
    }
}