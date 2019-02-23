namespace LearnDesign_Pattern.Builder_Patterns
{
    internal class BuildFirst : Builder
    {
        private readonly Computer computer = new Computer();

        public override void BuildPartCpu()
        {
            computer.Add("cpu");
        }

        public override void BuildPartMainBoard()
        {
            computer.Add("main board");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}