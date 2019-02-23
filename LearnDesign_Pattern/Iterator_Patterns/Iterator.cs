namespace LearnDesign_Pattern.Iterator_Patterns
{
    public interface ITerator
    {
        bool MoveNext();
        object GetCurrent();
        void Next();
        void Reset();
    }
}