namespace LearnDesign_Pattern.Iterator_Patterns
{
    public class ConcreteIterator : ITerator
    {
        private readonly ConcreteList _concreteList;
        private int _index;

        public ConcreteIterator(ConcreteList list)
        {
            _concreteList = list;
            _index = 0;
        }

        public bool MoveNext()
        {
            if (_index < _concreteList.Length) return true;

            return false;
        }

        public object GetCurrent()
        {
            return _concreteList.GetElement(_index);
        }

        public void Next()
        {
            if (_index < _concreteList.Length) _index++;
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}