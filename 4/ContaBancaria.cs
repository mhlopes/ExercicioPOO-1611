using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    public abstract class ContaBancaria
    {
        public int Numero;
        public float Saldo;

        public ContaBancaria(int numero)
        {
            Numero = numero;
            Saldo = 0;
        }

        public abstract float ValorDisponivel();

        public virtual void Depositar(float valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor inválido.");
                return;
            }
            this.Saldo += valor;
        }

        public virtual void Sacar(float valor)
        {
            Debitar(valor);
        }

        public void Transferir(float valor, ContaBancaria destino)
        {
            if (Debitar(valor))
            {
                destino.Depositar(valor);
            }
        }

        public void Pagar(float valor)
        {
            Debitar(valor);
        }

        public virtual bool Debitar(float valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor inválido.");
                return false;
            }
            if (valor > this.ValorDisponivel())
            {
                Console.WriteLine("Saldo insuficiente.");
                return false;
            }
            this.Saldo -= valor;
            return true;
        }

        public override string ToString()
        {
            return $"Número: {this.Numero}, Saldo: {this.Saldo}";
        }
    }
}
