using System;

namespace basic_stock
{
    public class Produto
    {
        //nome, preço e quantidade do produto
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        //métodos para adicionar e remover produtos do estoque
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        //método para exibir os dados do produto
        public override string ToString()
        {
            return $"{Nome}, R$ {Preco:F2}, {Quantidade} unidades, Total: R$ {ValorTotalEmEstoque():F2}";
        }
    }
}