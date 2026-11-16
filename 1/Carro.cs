using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    public class Carro
    {
        public string Fabricante;
        public string Modelo;
        public int AnoFabricacao;
        public int AnoModelo;
        public float ValorVenda;

        public Motor Motor;

        public Carro(string fabricante, string modelo, int anoFabricacao, int anoModelo, float valorVenda)
        {
            Fabricante = fabricante;
            Modelo = modelo;
            AnoFabricacao = anoFabricacao;
            AnoModelo = anoModelo;
            ValorVenda = valorVenda;
        }

        public string SetFabricante(string fabricante)
        {
            Fabricante = fabricante;
            return Fabricante;
        }

        public string SetModelo(string modelo)
        {
            Modelo = modelo;
            return Modelo;
        }

        public int SetAnoFabricacao(int anoFabricacao)
        {
            AnoFabricacao = anoFabricacao;
            return AnoFabricacao;
        }

        public int SetAnoModelo(int anoModelo)
        {
            AnoModelo = anoModelo;
            return AnoModelo;
        }
        public float SetValorVenda(float valorVenda)
        {
            ValorVenda = valorVenda;
            return ValorVenda;
        }

        public float CalculoIpva()
        {
            float ipva = ValorVenda * 0.04f;
            return ipva;
        }

        public string GetCarro()
        {
            return $"Fabricante: {Fabricante}\nModelo: {Modelo}\nAno de Fabricação: {AnoFabricacao}\nAno do Modelo: {AnoModelo}\nValor de Venda: {ValorVenda}";
        }
    }
}
