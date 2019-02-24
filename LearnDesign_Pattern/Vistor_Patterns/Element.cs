namespace LearnDesign_Pattern.Vistor_Patterns
{
    public abstract class Element
    {
        public abstract void Accept(IVistor vistor);
        public abstract void Print();
    }
}