using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    public class ContaBancaria
    {
        public string Titular;

        public int Saldo;

        public ContaBancaria(string titular, int saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        public ContaBancaria()
        {
        }

        public void Depositar(int valor, string titular)
        {
            this.Saldo += valor;
        }

        public void Sacar(int valor, string titular)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
        }

        public string AlterarTitular(string novoTitular)
        {
            this.Titular = novoTitular;
            return this.Titular;
        }

        public int ExibirSaldo()
        {
            return this.Saldo;
        }

        public string ToString()
        {
            return $"Titular: {this.Titular}, Saldo: {this.Saldo}";
        }
    }
}
