namespace LearnDesign_Pattern.Vistor_Patterns
{
    public interface IVistor
    {
        void Visit(ElementA a);
        void Visit(ElementB b); 
    }
}