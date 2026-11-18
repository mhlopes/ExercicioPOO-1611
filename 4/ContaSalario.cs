using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    public class ContaSalario : ContaBancaria
    {
        public ContaSalario(int numero) : base(numero)
        {
        }

        public override float ValorDisponivel()
        {
            return this.Saldo;
        }

        public override string ToString()
        {
            return $"Conta Salário - {base.ToString()}";
        }
    }
}
