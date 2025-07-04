namespace testes.Entities
{
    public class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public decimal Balance { get; protected set; }

        public Account()
        {

        }
        public Account(int number, string holder, decimal balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        //taxa de 5 reais pra saque
        public virtual void Withdraw(decimal amount)
        {
            Balance -= amount + 5;
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}