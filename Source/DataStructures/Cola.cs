using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace QueuesAnton.Source.DataStructures
{
    class Cola
    {
        private Node first; // Apunta al primer elemento de la cola
        private Node last;  // Apunta al último elemento de la cola
        private int length; // Número de elementos en la cola

        /// <summary>
        /// Constructor para inicializar una cola vacía.
        /// </summary>
        public Cola()
        {
            last = first = null;
            length = 0;
        }

        /// <summary>
        /// Constructor para inicializar la cola con un primer elemento.
        /// </summary>
        /// <param name="data">Dato inicial de la cola.</param>
        public Cola(object data)
        {
            last = first = new Node(data);
            length = 1;
        }

        /// <summary>
        /// Agrega un nuevo elemento al final de la cola.
        /// </summary>
        /// <param name="data">Dato a agregar.</param>
        public void Enqueue(object data)
        {
            if (IsEmpty())
            {
                last = first = new Node(data);
            }
            else
            {
                last = last.next = new Node(data); // Se enlaza el nuevo nodo y se actualiza el último nodo
            }
            length++;
        }

        /// <summary>
        /// Remueve y devuelve el primer elemento de la cola.
        /// </summary>
        /// <returns>El nodo eliminado o null si la cola está vacía.</returns>
        public Node Dequeue()
        {
            if (IsEmpty()) return null;

            Node temp = first;
            first = first.next;
            length--;

            if (first == null) // Si la cola queda vacía, también se actualiza last
            {
                last = null;
            }
            return temp;
        }

        /// <summary>
        /// Imprime todos los elementos de la cola en orden.
        /// </summary>
        public void PrintQueue()
        {
            Node current = first;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        /// <summary>
        /// Devuelve el primer nodo de la cola sin eliminarlo.
        /// </summary>
        public Node Front()
        {
            return IsEmpty() ? null : first;
        }

        /// <summary>
        /// Devuelve el último nodo de la cola sin eliminarlo.
        /// </summary>
        public Node Rear()
        {
            return IsEmpty() ? null : last;
        }

        /// <summary>
        /// Devuelve el valor del primer elemento de la cola sin eliminarlo.
        /// </summary>
        public object FrontValue()
        {
            return IsEmpty() ? null : first.data;
        }

        /// <summary>
        /// Devuelve el valor del último elemento de la cola sin eliminarlo.
        /// </summary>
        public object RearValue()
        {
            return IsEmpty() ? null : last.data;
        }

        /// <summary>
        /// Verifica si la cola está vacía.
        /// </summary>
        public bool IsEmpty() { return first == null; }

        /// <summary>
        /// Devuelve el número de elementos en la cola.
        /// </summary>
        public int Size() { return length; }
    }
}
