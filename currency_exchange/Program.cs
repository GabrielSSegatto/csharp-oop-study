using System;
using currency_exchange;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //recebe dados
            System.Console.WriteLine("Qual é a cotação do dólar hoje?");
            double cotacao = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Quantos dólares você quer comprar?");
            double quantidade = Convert.ToDouble(Console.ReadLine());

            //chama a função
            double valorEmReais = ConversorDeMoeda.DolarParaReal(cotacao, quantidade);

            //exibe o resultado
            System.Console.WriteLine($"O valor em reais é: {valorEmReais:F2}");
        }   
    }
}