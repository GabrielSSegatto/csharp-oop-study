using System;
using grades_manager;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciação aluno 
            Aluno aluno = new Aluno();

            //ler dados do aluno
            Console.WriteLine("Digite o nome do aluno:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite a nota 1:");
            aluno.Nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 2:");
            aluno.Nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 3:");
            aluno.Nota3 = Convert.ToDouble(Console.ReadLine());

            //primeiro trimestre vale 30, e os outros dois valem 35 cada

            System.Console.WriteLine($"nota final: {aluno.NotaFinal()}");

            //>=60 aprovado, < 60 reprovado

            System.Console.WriteLine(aluno.Aprovado());


        }
    }
}