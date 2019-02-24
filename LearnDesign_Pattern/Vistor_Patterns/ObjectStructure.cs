using System;
using System.Collections;

namespace LearnDesign_Pattern.Vistor_Patterns
{
    public class ObjectStructure
    {
        private ArrayList _elements = new ArrayList();

        public ArrayList Elements => _elements;

        public ObjectStructure()
        {
            Random random=new Random();
            for (int i = 0; i < 6; i++)
            {
                int ranNum = random.Next(10);
                if (ranNum>5)
                {
                    _elements.Add(new ElementA());
                }
                else
                {
                    _elements.Add(new ElementB());
                }
            }
        }
    }

}