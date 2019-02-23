using System.Collections.Generic;

namespace LearnDesign_Pattern.Composite_Patterns
{
    public class ComplexGraphics:Graphics
    {
        private  List<Graphics> _complexGraphicsList = new List<Graphics>();
        public ComplexGraphics(string name) : base(name)
        {
        }

        public override void Draw()
        {
            foreach (Graphics g in _complexGraphicsList)
            {
                g.Draw();
            }
        }

        public  void Add(Graphics graphics)
        {
            _complexGraphicsList.Add(graphics);
        }

        public  void Remove(Graphics graphics)
        {
            _complexGraphicsList.Remove(graphics);
        }
    }
}