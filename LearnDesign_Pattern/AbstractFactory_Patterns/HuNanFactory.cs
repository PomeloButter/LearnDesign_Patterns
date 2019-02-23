namespace LearnDesign_Pattern.AbstractFactory_Patterns
{
    internal class HuNanFactory : AbstractFactory
    {
        public override YaBo CreateYaBo()
        {
            return new HuNanYaBo();
        }

        public override YaJia CreateYaJia()
        {
            return new HuNanYaJia();
        }
    }
}