namespace LearnDesign_Pattern.Factory_Patterns
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
     abstract class Creator
    {
        //工厂方法
        public abstract Food CreateFoodFactory();
    }
}
