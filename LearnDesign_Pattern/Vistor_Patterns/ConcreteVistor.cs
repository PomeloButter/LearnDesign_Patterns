namespace LearnDesign_Pattern.Vistor_Patterns
{
    public class ConcreteVistor : IVistor
    {
        public void Visit(ElementA a)
        {
            a.Print();
        }

        public void Visit(ElementB b)
        {
            b.Print();
        }
    }
}