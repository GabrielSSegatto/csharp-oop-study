using worker_contracts.Entities.Enums;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace worker_contracts.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public decimal BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, decimal baseSalary, Department department)

        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public decimal Income(int year, int mounth)
        {
            decimal sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == mounth)
                {
                    sum += contract.TotalValue();
                }
            }
        return (decimal)sum;
        }
    }
}