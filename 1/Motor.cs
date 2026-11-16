using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    public class Motor
    {
        public string Tipo;
        public int Cilindrada;
        public int Potencia;
        public Motor(string tipo, int cilindrada, int potencia)
        {
            Tipo = tipo;
            Cilindrada = cilindrada;
            Potencia = potencia;
        }
        public string SetTipo(string tipo)
        {
            Tipo = tipo;
            return Tipo;
        }
        public int SetCilindrada(int cilindrada)
        {
            Cilindrada = cilindrada;
            return Cilindrada;
        }
        public int SetPotencia(int potencia)
        {
            Potencia = potencia;
            return Potencia;
        }
    }
}

