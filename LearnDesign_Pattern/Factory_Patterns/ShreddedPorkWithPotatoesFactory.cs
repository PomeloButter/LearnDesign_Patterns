namespace LearnDesign_Pattern.Factory_Patterns
{
    /// <summary>
    /// 土豆肉丝工厂类
    /// </summary>
    class ShreddedPorkWithPotatoesFactory : Creator
    {
        public override Food CreateFoodFactory()
        {
            return new ShreddedPorkWithPotatoes();
        }
    }
}
