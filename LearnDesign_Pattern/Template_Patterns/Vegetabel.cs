using System;

namespace LearnDesign_Pattern.Template_Patterns
{
    public abstract class Vegetabel
    {
        public void cookVegetable()
        {
            Console.WriteLine("炒蔬菜的一般方法");
            PourOil();
            HeatOil();
            PourVegetable();
            Stirfry();
        }

        private void Stirfry()
        {
            Console.WriteLine("翻炒");
        }

        public abstract void PourVegetable();

        private void HeatOil()
        {
            Console.WriteLine("把油烧热");
        }

        private void PourOil()
        {
            Console.WriteLine("倒油");
        }
    }
}