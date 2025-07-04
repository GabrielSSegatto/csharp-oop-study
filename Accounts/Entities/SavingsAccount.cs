using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testes.Entities
{
    public class SavingsAccount : Account
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, decimal balance, decimal interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        public override void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
            Balance -= 2;
        }

    }
}