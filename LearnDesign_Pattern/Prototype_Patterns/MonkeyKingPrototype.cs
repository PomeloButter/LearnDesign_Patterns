namespace LearnDesign_Pattern.Prototype_Patterns
{
    public abstract class MonkeyKingPrototype
    {
        public string Id { get; set; }

        public MonkeyKingPrototype(string id)
        {
            Id = id;
        }

        public abstract MonkeyKingPrototype Clone();
    }
}