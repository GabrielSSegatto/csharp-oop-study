using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enterprise.Entities
{
    public class OutsourcedEmployee : Employee
    {
        public decimal AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, decimal valuePerHour, decimal additionalCharge) : base (name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override decimal Payment()
        {
            return base.Payment() + 1.1m* AdditionalCharge;
        }
    }
}