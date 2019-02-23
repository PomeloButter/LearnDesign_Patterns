namespace LearnDesign_Pattern.Decorator_Patterns
{
    public class Decorator : Phone
    {
        private readonly Phone _phone;

        public Decorator(Phone phone)
        {
            _phone = phone;
        }

        public override void Print()
        {
            _phone?.Print();
            ;
        }
    }
}