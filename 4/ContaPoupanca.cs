using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numero) : base(numero)
        {
        }

        public override float ValorDisponivel()
        {
            return this.Saldo;
        }

        public override void Sacar(float valor)
        {
            Debitar(valor * 1.05f);
        }

        public override string ToString()
        {
            return $"Conta Poupança - {base.ToString()}";
        }
    }
}
