namespace LearnDesign_Pattern.Stragety_Patterns
{
    public class PersonalTaxStrategy:ITaxStragety
    {
        public double CalculateTax(double income)
        {
            return income * 0.12;
        }
    }
}