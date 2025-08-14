
using Tax.Entities;
using System.Collections.Generic;

Console.WriteLine("Enter the number of tax payers");
int n = int.Parse(Console.ReadLine());

List<Person> persons = new List<Person>();

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Tax payer #{i + 1} data: ");
    Console.Write("Individual or company (i/c)? ");
    char c = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    decimal anualIncome = decimal.Parse(Console.ReadLine());

    if (c == 'i')
    {
        Console.Write("Health expenditures: ");
        decimal healthExpenditures = decimal.Parse(Console.ReadLine());
        persons.Add(new NaturalPerson(name, anualIncome, healthExpenditures));
    }
    else if (c == 'c')
    {
        Console.Write("Number of employess: ");
        int e = int.Parse(Console.ReadLine());
        persons.Add(new JuridicalPerson(name, anualIncome, e));
    }
}
Console.WriteLine("TAXES PAID: ");

decimal total = 0;
foreach (Person p in persons)
{
    p.CalcTax();
    Console.WriteLine($"{p.Name}: ${p.Tax}");
    total += p.Tax;
}

Console.Write($"TOTAL TAXES: ${total}");

