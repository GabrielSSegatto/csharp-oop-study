
namespace Tax.Entities
{
    public class NaturalPerson : Person
    {
        public decimal HealthExpense { get; set; }

        public NaturalPerson()
        {}
        public NaturalPerson(string name, decimal annualIncome, decimal healthExpense) : base(name, annualIncome)
        {
            HealthExpense = healthExpense;
        }

        public override void CalcTax()
        {
            if (AnnualIncome >= 20000m)
            {
                Tax = (AnnualIncome * 0.25m) - (HealthExpense * 0.50m);
            }
            else
            {
                Tax = (AnnualIncome * 0.15m) - (HealthExpense * 0.50m);
            }
        }
    }
}