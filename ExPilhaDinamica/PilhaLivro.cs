using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ExPilhaDinamica
{
    internal class PilhaLivro
    {
        public Livro Topo { get; set; }

        public PilhaLivro()
        {
            Topo = null;
            Console.WriteLine("Pilha criada com sucesso!\n");
        }

        public void Push(Livro aux)
        {
            aux.Anterior = Topo;
            Topo = aux;   
        }

        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível remover.\n Piha Vazia!\n");
            }
            else
            {
                Topo = Topo.Anterior;
            }
        }

        public void PrintPilha()
        {
            Livro aux;
            if (Vazia())
            {
                Console.WriteLine("Impossível imprimir.\nPilha vazia!\n");
                return;
            }
            else
            {
                aux = Topo;
                Console.WriteLine("Os elementos da Pilha são: \n");
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                } while (aux != null);
                Console.WriteLine("Final da Pilha...\n");
            }
        }

        private bool Vazia()
        {
            //if(Topo == null) return true; else return false;
            return Topo == null ? true : false;
        }
    }
}
