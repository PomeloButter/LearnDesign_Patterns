namespace LearnDesign_Pattern.Bridge_Patterns
{
    public class RemoteControl
    {
        public Tv Implementor { get; set; }

        public virtual void On()
        {
            Implementor.On();
        }

        public virtual void Off()
        {
            Implementor.Off();
        }

        public virtual void SetChannel()
        {
            Implementor.TuneChannel();
        }
    }
}