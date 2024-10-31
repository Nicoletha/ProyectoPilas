using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_pila
{
    internal class pila
    {
        private int MAX; // Máximo de elementos que puede tener la pila
        private int tope = 0; // Cantidad de elementos actuales en la pila
        private Nodo inicio; // Nodo de referencia al primer elemento de la pila (la cima)

        // Constructor: Inicializo la pila con el tamaño máximo que le pase
        public pila(int max)
        {
            MAX = max;
            inicio = null; // Al principio, la pila está vacía
        }

        // Verifica si la pila está vacía
        public bool Empty()
        {
            return inicio == null; // Si no hay ningún nodo, está vacía
        }

        // Verifica si la pila está llena
        public bool Full()
        {
            return tope == MAX; // Si el número de elementos llega al máximo, está llena
        }

        // Muestra todos los elementos en la pila
        public void PrintStack()
        {
            if (Empty()) // Si está vacía, solo muestra un mensaje y termina
            {
                Console.WriteLine("La pila está vacía.");
                return;
            }

            Nodo nodoActual = inicio; // Empiezo desde el primer nodo

            Console.WriteLine("Contenido de la pila:");
            while (nodoActual != null) // Mientras haya elementos
            {
                Console.WriteLine($"- {nodoActual.Valor}"); // Imprimo el valor actual
                nodoActual = nodoActual.Sig; // Paso al siguiente nodo
            }

            Console.WriteLine("--- Fin de la pila ---\n");
        }

        // Agrega un nuevo elemento a la pila
        public bool Push(int valor)
        {
            if (Full()) // Si la pila está llena, aviso y no hago nada
            {
                Console.WriteLine("\nLa pila está llena. No se pueden agregar más elementos.\n");
                return false;
            }

            Nodo nuevoNodo = new Nodo(valor); // Creo un nuevo nodo con el valor que pasen

            if (Empty()) // Si está vacía, el nuevo nodo será el primero
            {
                inicio = nuevoNodo;
            }
            else // Si ya tiene elementos, el nuevo nodo se vuelve la cima
            {
                nuevoNodo.Sig = inicio;
                inicio = nuevoNodo;
            }

            tope++; // Incremento la cuenta de elementos
            Console.WriteLine($"\nElemento {valor} agregado a la pila.\n");
            return true;
        }

        // Elimina el elemento en la cima de la pila
        public int Pop()
        {
            if (Empty()) // Si está vacía, aviso y devuelvo -1
            {
                Console.WriteLine("\nNo hay elementos en la pila para desapilar.\n");
                return -1;
            }

            int valorEliminado = inicio.Valor; // Guardo el valor que voy a eliminar
            inicio = inicio.Sig; // Paso al siguiente nodo (eliminando el actual)
            tope--; // Disminuyo la cuenta de elementos

            Console.WriteLine($"\nElemento {valorEliminado} removido de la pila.\n");
            return valorEliminado; // Devuelvo el valor eliminado
        }
    }
}
