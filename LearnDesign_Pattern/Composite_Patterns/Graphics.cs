namespace LearnDesign_Pattern.Composite_Patterns
{
    public abstract class Graphics
    {
        public Graphics(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public abstract void Draw();
    }
}