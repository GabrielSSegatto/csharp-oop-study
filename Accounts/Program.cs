
using testes.Entities;

/* 

UpCasting e DownCasting

Account acc = new Account(1001, "ALex", 0);
BusinessAcount bacc = new BusinessAcount(1002, "Maria", 0, 500);


//upcasting

Account acc1 = bacc;
Account acc2 = new BusinessAcount(1003, "Bob", 0, 200);
Account acc3 = new SavingsAccount(1004, "Anna", 0, 0.01m);

//downcasting

BusinessAcount acc4 = (BusinessAcount)acc2;
acc4.Loan(100);
//acc2.Loan(100); n aceita pois a função Loan é da classe BuisnessAcount, oq importa é o tipo dela, n importa que dentro dela seja uma buisnessAccount se o tipo dela for Account

//BusinessAcount acc5 = (BusinessAcount)acc3; Acc3 é do tipo SavingsAccount, n compativel com o tipo Buisness

if (acc3 is BusinessAcount)
{
    //BusinessAcount acc5 = (BusinessAcount)acc3;
    BusinessAcount acc5 = acc3 as BusinessAcount;
    acc5.Loan(200);
    Console.WriteLine("Loan!");
}
if (acc3 is SavingsAccount)
{
    //SavingsAccount acc5 = (SavingsAccount)acc3;
    SavingsAccount acc5 = acc3 as SavingsAccount;
    acc5.UpdateBalance();
    Console.WriteLine("Update!");
}
//forma segura de fazer o downCasting

*/

Account acc1 = new Account(1001, "Alex", 500);
Account acc2 = new SavingsAccount(1002, "Anna", 500, 0.01m);

acc1.Withdraw(10);
acc2.Withdraw(10);

Console.WriteLine(acc1.Balance);

Console.WriteLine(acc2.Balance);