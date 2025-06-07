using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace bank
{
    public class Conta
    {
        //propriedades
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public decimal Saldo { get; private set; }
        public decimal _depositoInicial { get; private set; }

        // Construtores
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public Conta(int numero, string titular, decimal depositoInicial)
        {
            Numero = numero;
            Titular = titular;
            _depositoInicial = depositoInicial;
            Saldo = depositoInicial;
        }

        //Métodos
        public void Depositar(decimal valor)
        {
            if (valor >= 0)
            {
                Saldo += valor;
            }
            else
            {
                System.Console.WriteLine("Valor do depósito inválido.");
            }
        }

        //Ao sacar será cobrado uma taxa fixa de R$ 5.00
        public void Sacar(decimal valor)
        {
            if (valor != 0)
            {
                Saldo -= valor - 5.00m;
            }
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: R${Saldo:F2}";
        }

    }


}