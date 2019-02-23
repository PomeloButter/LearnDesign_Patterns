namespace LearnDesign_Pattern.Builder_Patterns
{
    internal class BuildSecond : Builder
    {
        private readonly Computer computer = new Computer();

        public override void BuildPartCpu()
        {
            computer.Add("Cpu A");
        }

        public override void BuildPartMainBoard()
        {
            computer.Add("MainBoard A");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}