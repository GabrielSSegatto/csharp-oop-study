using System;
using System.Net;
using System.Net.Http.Headers;

namespace basic_stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            //solicita os dados do produto
            System.Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            //exibe os dados do produto
            System.Console.WriteLine("Dados do produto: " + p);

            //Adciona produtos ao estoque e mostra os dados atualizados
            System.Console.WriteLine();
            System.Console.Write("Digite o número de produtos a ser adicionado ao estoque:");
            int quantidadeAdicionar = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quantidadeAdicionar);
            System.Console.WriteLine("Dados atualizados: " + p);

            //Remove produtos do estoque e mostra os dados atualizados
            System.Console.WriteLine();
            System.Console.Write("Digite o número de produtos a ser removidos ao estoque:");
            int quantidadeRemover = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quantidadeRemover);
            System.Console.WriteLine("Dados atualizados: " + p);
        }
    }
}