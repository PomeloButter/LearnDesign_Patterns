namespace LearnDesign_Pattern.Prototype_Patterns
{
    public abstract class MonkeyKingPrototype
    {
        public MonkeyKingPrototype(string id)
        {
            Id = id;
        }

        public string Id { get; set; }

        public abstract MonkeyKingPrototype Clone();
    }
}