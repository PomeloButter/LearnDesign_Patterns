namespace LearnDesign_Pattern.Decorator_Patterns
{
    public class Decorator:Phone
    {
        private Phone _phone;

        public Decorator(Phone phone)
        {
            this._phone = phone;
        }

        public override void Print()
        {
            _phone?.Print();;
        }
    }
}