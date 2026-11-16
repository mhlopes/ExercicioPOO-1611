using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public int NumeroPaginas;

        public Livro(string titulo, string autor, int numeroPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas > 0 ? numeroPaginas : 0;
        }

        public string GetTitulo()
        {
            return this.Titulo;
        }

        public string GetAutor()
        {
            return this.Autor;
        }

        public int GetNumeroPaginas()
        {
            return this.NumeroPaginas;
        }

        public string ToString()
        {
            return $"Título: {this.Titulo}, Autor: {this.Autor}, Número de Páginas: {this.NumeroPaginas}";
        }
    }
}
