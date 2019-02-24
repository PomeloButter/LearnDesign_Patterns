namespace LearnDesign_Pattern.Stragety_Patterns
{
    public class InterestOperation
    {
        private ITaxStragety m_strategy;

        public InterestOperation(ITaxStragety mStrategy)
        {
            m_strategy = mStrategy;
        }

        public double GetTax(double income)
        {
            return m_strategy.CalculateTax(income);
        }
    }
}