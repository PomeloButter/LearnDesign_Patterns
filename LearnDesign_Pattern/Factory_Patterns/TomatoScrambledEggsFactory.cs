namespace LearnDesign_Pattern.Factory_Patterns
{
    /// <summary>
    /// 西红柿炒鸡蛋工厂类
    /// </summary>
    class TomatoScrambledEggsFactory : Creator
    {
        public override Food CreateFoodFactory()
        {
            return new TomatoScrambledEggs();
        }
    }
}
