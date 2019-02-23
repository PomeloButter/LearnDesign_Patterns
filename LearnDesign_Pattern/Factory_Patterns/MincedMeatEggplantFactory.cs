namespace LearnDesign_Pattern.Factory_Patterns
{
    internal class MincedMeatEggplantFactory : Creator
    {
        public override Food CreateFoodFactory()
        {
            return new MincedMeatEggplant();
        }
    }
}