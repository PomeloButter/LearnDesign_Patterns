namespace LearnDesign_Pattern.Builder_Patterns
{
    internal abstract class Builder
    {
        //装cpu
        public abstract void BuildPartCpu();

        //装主板
        public abstract void BuildPartMainBoard();

        //获得组装的电脑
        public abstract Computer GetComputer();
    }
}