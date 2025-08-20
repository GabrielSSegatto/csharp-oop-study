
using Account_2.Entities;
using Account_2.Entities.Exceptions;



    Console.WriteLine("Enter account data: ");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string name = Console.ReadLine();
    Console.Write("Initial balance: ");
    decimal initialBalance = decimal.Parse(Console.ReadLine());
    Console.Write("Withdraw limit: ");
    decimal withdrawLimit = decimal.Parse(Console.ReadLine());

    Account acc = new Account(number, name, initialBalance, withdrawLimit);

    Console.WriteLine();

    Console.Write("Enter amount for withdraw: ");
    decimal amount = decimal.Parse(Console.ReadLine());
try
{
    acc.Withdraw(amount);
    Console.WriteLine($"New balance: {acc.Balance}");
}

catch (DomainException e)
{
    Console.WriteLine("Error in Withdraw: " + e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Format error: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unspected error: " + e.Message);
}


