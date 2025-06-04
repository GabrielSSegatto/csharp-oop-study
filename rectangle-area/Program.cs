using System;
using rectangle_area;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            // Solicita ao usuário as dimensões do retângulo
            Console.WriteLine("Digite a largura do retângulo:");
            retangulo.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do retângulo:");
            retangulo.Altura = double.Parse(Console.ReadLine());

            // Calcula a área do retângulo
            double area = retangulo.Area();

            //calcula o perímetro do retângulo
            double perimetro = retangulo.Perimetro();

            // Calcula a diagonal do retângulo
            double diagonal = retangulo.Diagonal();

            // Exibe os resultados
            Console.WriteLine($"Área do retângulo: {area:F2}");
            Console.WriteLine($"Perímetro do retângulo: {perimetro:F2}");
            Console.WriteLine($"Diagonal do retângulo: {diagonal:F2}");
            
        }
    }
}