using System;


namespace rectangle_area
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        // Método para calcular a área do retângulo
        public double Area()
        {
            return Largura * Altura;
        }
        //Método para calcular o perímetro do retângulo
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        // Método para calcular a diagonal do retângulo
        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }
    }
}