

using System.Security.Cryptography;

namespace testes.Entities
{
    public class BusinessAcount : Account
    {
        public decimal LoanLimit { get; set; }

        public BusinessAcount()
        {

        }

        public BusinessAcount(int number, string holder, decimal balance, decimal loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(decimal amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
            
        }

    }
}
