namespace LearnDesign_Pattern.Command_Patterns
{
    public class Invoke
    {
        public Command Command;

        public Invoke(Command command)
        {
            Command = command;
        }

        public void ExecuteCommand()
        {
            Command.Action();
        }
    }
}