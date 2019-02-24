namespace LearnDesign_Pattern.Mediator_Patterns
{
    public abstract class AbstractMediator
    {
        protected AbstractCardPartner _a;
        protected AbstractCardPartner _b;

        public AbstractMediator(AbstractCardPartner a, AbstractCardPartner b)
        {
            _a = a;
            _b = b;
        }

        public abstract void Awin(int count);
        public abstract void Bwin(int count);
    }
}