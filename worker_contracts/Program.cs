using worker_contracts.Entities.Enums;
using worker_contracts.Entities;
using System;
using System.Globalization;

Console.Write("Enter department name: ");
string departmentName = Console.ReadLine();
Console.WriteLine("Enter worker data:");
Console.Write("Name: ");
string workerName = Console.ReadLine();
Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Base salary: ");
decimal baseSalary = decimal.Parse(Console.ReadLine());

Department department = new Department(departmentName);
Worker worker = new Worker(workerName, level, baseSalary, department);

// Adding contracts to the worker
Console.Write("How many contracts to this worker? ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} contract data:");
    Console.Write("Date (MM/DD/YYYY): "); //using MM/DD/YYYY format for consistency. EUA format
    DateTime date = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
    Console.Write("Value per hour: ");
    decimal valuePerHour = decimal.Parse(Console.ReadLine());
    Console.Write("Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());

    HourContract contract = new HourContract(date, valuePerHour, hours);
    worker.AddContract(contract);
}

Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string monthAndYear = Console.ReadLine();
// Extracting month and year from the input with substring
int month = int.Parse(monthAndYear.Substring(0, 2));
int year = int.Parse(monthAndYear.Substring(3, 4));

Console.WriteLine($"Name: {worker.Name}");
Console.WriteLine($"Department: {worker.Department.Name}");
Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month):F2}");
