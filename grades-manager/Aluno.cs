using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grades_manager
{
    public class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;


        public double NotaFinal()
        {
            //primeiro trimestre vale 30, e os outros dois valem 35 cada
            return Nota1 + Nota2 + Nota3;
        }

        public string Aprovado()
        {
            //se a nota final for maior ou igual a 60, aluno será aprovado
            if (NotaFinal() >= 60)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO \n" +
                       "FALTARAM " + (60 - NotaFinal()) + " PONTOS PARA SER APROVADO";
            }
        }
    }
}