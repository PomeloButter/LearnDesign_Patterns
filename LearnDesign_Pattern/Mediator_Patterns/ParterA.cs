namespace LearnDesign_Pattern.Mediator_Patterns
{
    public class ParterA:AbstractCardPartner
    {
        public override void ChangCount(int count, AbstractMediator mediator)
        {
            mediator.Awin(count);
        }
    }
}