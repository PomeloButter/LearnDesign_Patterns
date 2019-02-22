namespace LearnDesign_Pattern.Factory_Patterns
{
    class MincedMeatEggplantFactory:Creator
    {
        public override Food CreateFoodFactory()
        {
          return  new MincedMeatEggplant();
        }
    }
}
