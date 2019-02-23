namespace LearnDesign_Pattern.Prototype_Patterns
{
    public class ConcretePrototype : MonkeyKingPrototype
    {
        public ConcretePrototype(string id) : base(id)
        {
        }

        public override MonkeyKingPrototype Clone()
        {
            return (MonkeyKingPrototype) MemberwiseClone();
        }
    }
}