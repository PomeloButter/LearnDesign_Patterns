namespace LearnDesign_Pattern.AbstractFactory_Patterns
{
    class HuNanFactory:AbstractFactory
    {
        public override YaBo CreateYaBo()=>new HuNanYaBo();

        public override YaJia CreateYaJia() =>new HuNanYaJia();
    }
}
