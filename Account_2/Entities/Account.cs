using System;
using System.Collections.Generic;
using Account_2.Entities.Exceptions;


namespace Account_2.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public decimal Balance { get; set; }
        public decimal WithdrawLimit { get; set; }

        public Account()
        { }
        public Account(int number, string holder, decimal balance, decimal withdrawLimit)
        {
            
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            else if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }
            Balance -= amount;
        }
    }
}