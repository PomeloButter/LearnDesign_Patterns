namespace LearnDesign_Pattern.AbstractFactory
{
    public class ShangHaiFactory:AbstractFactory
    {
        public override YaBo CreateYaBo() => new NanChangYaBo();

        public override YaJia CreateYaJia() => new NanChangYaJia();

    }
}