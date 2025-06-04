using System;
using System.Xml;
using employees;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            // Leitura dos dados do funcionário
            System.Console.WriteLine("Nome:");
            funcionario.Nome = Console.ReadLine();
            System.Console.WriteLine("Salario bruto:");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Imposto:");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            //exibição informações do funcionário
            System.Console.WriteLine(funcionario);

            //aumento salárial
            System.Console.WriteLine("Digite a porcentagem de aumento salarial:");
            double porcentagem = double.Parse(Console.ReadLine());
            funcionario.AumentarSalario(porcentagem);

            //exibe dados atualizados
            System.Console.WriteLine("dados atualizados: ");
            System.Console.Write(funcionario);
        }
    }
}