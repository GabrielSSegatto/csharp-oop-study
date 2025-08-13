using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace Products.Entities
{
    public class ImportedProduct : Product
    {
        public decimal CustomsFee { get; set; }
        public ImportedProduct()
        {}
        public ImportedProduct(string name, decimal price, decimal customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }
        public override string PriceTag()
        {
            return $"{Name} ${Price + CustomsFee} (Customs Fee: ${CustomsFee})";
        }
    }
}