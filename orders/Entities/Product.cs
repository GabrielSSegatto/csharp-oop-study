using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orders.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
        }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

}