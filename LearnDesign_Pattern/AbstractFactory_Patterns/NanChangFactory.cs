namespace LearnDesign_Pattern.AbstractFactory_Patterns
{
    public class NanChangFactory:AbstractFactory
    {
        public override YaBo CreateYaBo() => new NanChangYaBo();

        public override YaJia CreateYaJia() => new NanChangYaJia();

    }
}