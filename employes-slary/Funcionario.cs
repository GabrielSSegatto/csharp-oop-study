using System;
using System.Collections.Generic;
using System.Linq;


namespace employes_slary
{
    public class Funcionario
    {
        // Propriedades
        public int Id { get; private set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        // Construtor
        public Funcionario(int id, string nome, decimal salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        // Métodos


        public void AumentarSalario(decimal percentual)
        {
            if (percentual < 0)
            {
                Console.WriteLine("Percentual de aumento não pode ser negativo.");
            }
            else
            {
                Salario += Salario * (percentual / 100);
            }
        }

        public void DiminuirSalario(decimal percentual)
        {
            if (percentual < 0)
            {
                Console.WriteLine("Percentual de diminuição não pode ser negativo.");
            }
            else
            {
                Salario -= Salario * (percentual / 100);
                if (Salario < 0)
                {
                    Salario = 0; // Evita que o salário fique negativo
                }
            }
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Salário: {Salario:F2}";
        }
    }
}
