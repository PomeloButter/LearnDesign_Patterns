namespace LearnDesign_Pattern.Bridge_Patterns
{
    public class RemoteControl
    {
        private Tv _implementor;

        public Tv Implementor
        {
            get => _implementor;
            set => _implementor = value;
        }

        public virtual void On()
        {
            _implementor.On();
        }

        public virtual void Off()
        {
            _implementor.Off();
        }

        public virtual void SetChannel()
        {
            _implementor.TuneChannel();
        }
    }
}