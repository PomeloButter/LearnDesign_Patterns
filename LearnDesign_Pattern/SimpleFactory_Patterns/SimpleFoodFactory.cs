namespace LearnDesign_Pattern.SimpleFactory_Patterns
{
    /// <summary>
    ///     简单工厂模式系统难以扩展，一旦添加新产品就不得不修改简单工厂方法，这样就会造成简单工厂的实现逻辑过于复杂
    /// </summary>
    internal class SimpleFoodFactory
    {
        public static Food CreateFood(string type)
        {
            Food food = null;
            if (type.Equals("ShreddedPorkWithPotatoes")) food = new ShreddedPorkWithPotatoes();
            if (type.Equals("TomaoScrambledEggs")) food = new TomaoScrambledEggs();
            return food;
        }
    }
}