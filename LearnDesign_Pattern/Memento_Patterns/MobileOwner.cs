using System;
using System.Collections.Generic;

namespace LearnDesign_Pattern.Memento_Patterns
{
    public class MobileOwner
    {
        public MobileOwner(List<ContactPerson> contactPersons)
        {
            ContactPersons = contactPersons;
        }

        public List<ContactPerson> ContactPersons { get; set; }

        public ContactMemento CreateContactMemento()
        {
            return  new ContactMemento(new List<ContactPerson>(this.ContactPersons));
        }

        public void RestoreMemento(ContactMemento contactMemento)
        {
            if (contactMemento!=null)
            {
                this.ContactPersons = contactMemento.ContactPersonBack;
            }
        }

        public void Show()
        {
            Console.WriteLine("联系人列表中有{0}个人，他们是:", ContactPersons.Count);
            foreach (ContactPerson p in ContactPersons)
            {
                Console.WriteLine("姓名: {0} 号码为: {1}", p.Name, p.MobileNum);
            }
        }
    }
}