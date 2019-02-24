namespace LearnDesign_Pattern.Mediator_Patterns
{
    public class MediatorPater:AbstractMediator
    {
        public MediatorPater(AbstractCardPartner a, AbstractCardPartner b) : base(a, b)
        {
        }

        public override void Awin(int count)
        {
            _a.MoneyCount += count;
            _b.MoneyCount -= count;
        }

        public override void Bwin(int count)
        {
            _a.MoneyCount -= count;
            _b.MoneyCount += count;
        }
    }
}