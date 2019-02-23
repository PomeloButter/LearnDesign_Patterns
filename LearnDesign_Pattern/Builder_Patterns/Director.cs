namespace LearnDesign_Pattern.Builder_Patterns
{
    internal class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartCpu();
            builder.BuildPartMainBoard();
        }
    }
}