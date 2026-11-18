using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    public class ContaCorrente : ContaBancaria
    {
        public float Limite { get; private set; }

        public ContaCorrente(int numero) : base(numero)
        {
        }

        public float DefinirLimite()
        {
            if (this.Saldo > 0)
            {
                this.Limite = Saldo * 3;
            }
            else
            {
                this.Limite = 0;
            }

            return Limite;
        }

        public override void Depositar(float valor)
        {
            base.Depositar(valor);
            DefinirLimite();
        }

        public override bool Debitar(float valor)
        {
            bool resultado = base.Debitar(valor);
            DefinirLimite();
            return resultado;
        }
        
        public override float ValorDisponivel()
        {
            return this.Saldo + this.Limite;
        }

        public override string ToString()
        {
            return $"Conta Corrente - {base.ToString()}, Limite: {this.Limite}";
        }
    }
}
