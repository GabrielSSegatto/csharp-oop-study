using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employees
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        //calcula salario liquido
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        //aumenta salario
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return $"{Nome}, $ {SalarioLiquido():F2}";
        }
    }
}