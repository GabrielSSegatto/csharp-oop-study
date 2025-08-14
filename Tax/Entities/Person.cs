
namespace Tax.Entities
{
    public abstract class Person
    {
        public string Name { get; set; }
        public decimal AnnualIncome { get; set; }
        public decimal Tax { get; protected set; }

        public Person()
        {
        }
        public Person(string name, decimal annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract void CalcTax();
    }
}