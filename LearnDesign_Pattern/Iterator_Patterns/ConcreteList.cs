using System.Collections;

namespace LearnDesign_Pattern.Iterator_Patterns
{
    public class ConcreteList:IListCollection
    {
        int[] collection;

        public ConcreteList()
        {
            this.collection = new int[]{2,3,4,5};
        }

        public ITerator GetITerator()
        {
            return new ConcreteIterator(this);
        }

        public int Length => collection.Length;

        public int GetElement(int index)
        {
            return collection[index];
        }
    }
}