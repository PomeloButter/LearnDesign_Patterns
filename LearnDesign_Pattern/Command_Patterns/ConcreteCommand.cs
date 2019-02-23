namespace LearnDesign_Pattern.Command_Patterns
{
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Action()
        {
            Receiver.Run();
        }
    }
}