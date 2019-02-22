namespace LearnDesign_Pattern.Adapter_Patterns
{
    public class PowerAdapter : ThreeHole
    {
        public TwoHole TwoHole=new TwoHole();
        public override void Request()
        {
            TwoHole.SpecificRequest();
        }
    }
}