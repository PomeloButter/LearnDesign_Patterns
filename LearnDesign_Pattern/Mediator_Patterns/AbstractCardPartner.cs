namespace LearnDesign_Pattern.Mediator_Patterns
{
    public abstract class AbstractCardPartner
    {
        public int MoneyCount { get; set; }

        public AbstractCardPartner()
        {
            MoneyCount = 0;
        }

        public abstract void ChangCount(int count, AbstractMediator mediator);
    }
}