using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Entities
{
    public class UsedProduct : Product
    {
        public DateOnly ManufactureDate { get; set; }
        public UsedProduct()
        {}
        public UsedProduct(string name, decimal price, DateOnly manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) ${Price} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}