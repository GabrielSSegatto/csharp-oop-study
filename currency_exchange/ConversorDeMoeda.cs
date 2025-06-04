using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace currency_exchange
{
    public class ConversorDeMoeda
    {

        public static double DolarParaReal(double cotacao, double quantidade)
        {
            return cotacao * (quantidade * 1.06);
            // Inclui uma taxa de 6% para cobrir taxas de conversão
        }
    }
}