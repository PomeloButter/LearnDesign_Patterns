namespace LearnDesign_Pattern.Mediator_Patterns
{
    public class ParterB:AbstractCardPartner
    {
        public override void ChangCount(int count, AbstractMediator mediator)
        {
            mediator.Bwin(count);
        }
    }
}