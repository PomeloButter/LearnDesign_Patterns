using System;

namespace LearnDesign_Pattern.Composite_Patterns
{
    public abstract class Graphics
    {
        public string Name { get; set; }

        public Graphics(string name)
        {
            this.Name = name;
        }

        public abstract void Draw();
    }
}