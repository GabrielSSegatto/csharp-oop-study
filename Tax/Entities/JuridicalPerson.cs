

namespace Tax.Entities
{
    public class JuridicalPerson : Person
    {
        public int EmployeesNumber { get; set; }

        public JuridicalPerson()
        { }
        public JuridicalPerson(string name, decimal annualIncome, int employessNumber) : base(name, annualIncome)
        {
            EmployeesNumber = employessNumber;
        }

        public override void CalcTax()
        {
            if (EmployeesNumber >= 10)
            {
                Tax = AnnualIncome * 0.14m;
            }
            else
            {
                Tax = AnnualIncome * 0.16m;
            }
        }
    }
}