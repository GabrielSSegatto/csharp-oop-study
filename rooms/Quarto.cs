using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rooms
{
    public class Quarto
    {
        //propriedades
        public string Nome { get; set; }
        public string Email { get; set; }

        //Construtor
        public Quarto(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        //Método ToString para exibir os dados do hóspede
        public override string ToString()
        {
            return $"{Nome}, {Email}";
        }
    }
}