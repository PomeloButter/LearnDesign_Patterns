namespace LearnDesign_Pattern.Stragety_Patterns
{
    public class EnterpriseTaxStrategy:ITaxStragety
    {
        public double CalculateTax(double income)
        {
            return (income - 3500) > 0 ? (income - 3500) * 0.045 : 0.0;
        }
    }
}