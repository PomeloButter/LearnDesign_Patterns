namespace LearnDesign_Pattern.Factory_Patterns
{
    /// <summary>
    ///     西红柿炒鸡蛋工厂类
    /// </summary>
    internal class TomatoScrambledEggsFactory : Creator
    {
        public override Food CreateFoodFactory()
        {
            return new TomatoScrambledEggs();
        }
    }
}