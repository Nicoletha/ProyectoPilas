using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_pila
{
    internal class Nodo
    {
        private int valor;
        private Nodo sig;
        public Nodo(int Valor)
        {
            valor = Valor;
        }

        public int Valor { get => valor; set => valor = value; }
        internal Nodo Sig { get => sig; set => sig = value; }
    }
}
