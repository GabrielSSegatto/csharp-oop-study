using System;
using bank;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita os dados da conta
            System.Console.Write("Entre o número da conta:");
            int numero = int.Parse(Console.ReadLine());
            System.Console.Write("Entre o titular da conta:");
            string titular = Console.ReadLine();
            System.Console.Write("Haverá depósito inicial? (s/n):");
            char resposta = char.Parse(Console.ReadLine());

            // Cria a variavel conta
            Conta conta;

            // Verifica se o usuário deseja fazer um depósito inicial
            if (resposta == 's' || resposta == 'S')
            {
                System.Console.Write("Entre o valor do depósito inicial: ");
                decimal depositoInicial = decimal.Parse(Console.ReadLine());

                conta = new Conta(numero, titular, depositoInicial);
            }
            else
            {
                conta = new Conta(numero, titular);
            }

            // Exibe os dados da conta
            System.Console.WriteLine();
            System.Console.WriteLine("Dados da conta:");
            System.Console.WriteLine(conta);

            //deposito
            System.Console.Write("Entre um valor para depósito:");
            decimal valorDeposito = decimal.Parse(Console.ReadLine());
            conta.Depositar(valorDeposito);

            // Exibe os dados da conta após o depósito
            System.Console.WriteLine("Dados da conta atualizados:");
            System.Console.WriteLine(conta);

            //saque
            System.Console.Write("Entre um valor para saque:");
            decimal valorSaque = decimal.Parse(Console.ReadLine());
            conta.Sacar(valorSaque);

            // Exibe os dados da conta após o saque
            System.Console.WriteLine("Dados da conta atualizados:");
            System.Console.WriteLine(conta);

        }
    }
}