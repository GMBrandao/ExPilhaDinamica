using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPilhaDinamica
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public Livro Anterior {get; set; }

        public Livro(string titulo, string autor, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
            Anterior = null;
        }

        public override string ToString()
        {
            return ">>>DADOS DO LIVRO<<<\n" + "Título: " + Titulo + "\nAutor: " + Autor + "\nAno Publicado: "+ Ano+ "\n";
        }
    }
}
