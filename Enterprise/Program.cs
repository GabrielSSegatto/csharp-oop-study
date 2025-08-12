using System.ComponentModel.Design.Serialization;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
using Enterprise.Entities;


List<Employee> list = new List<Employee>();

Console.Write("Enter the number of employees: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Employee {i} data: ");

    Console.Write("Outsourced (y/n)? ");
    char outsourced = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours:");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    decimal valuePerHour = decimal.Parse(Console.ReadLine());

    if (outsourced == 'y')
    {
        Console.Write("Additional charge: ");
        decimal additionalCharge = decimal.Parse(Console.ReadLine());
        list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
    }
    else
    {
        list.Add(new Employee(name, hours, valuePerHour));
    }
}
Console.WriteLine();
    Console.WriteLine("PAYMENTS: ");
    foreach (Employee employee in list)
    {
        Console.WriteLine($"{employee.Name} - $ {employee.Payment().ToString("F2")}");
    }