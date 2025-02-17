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
        private Node first;
        private Node last;

        private int length;

        public Cola()
        {
            last = first = null;
            length = 0;
        }

        public Cola(object data)
        {
            last = first = new Node(data);
            length = 1;
        }

        public void Enqueue(object data)
        {
            if (IsEmpty())
            {
                last = first = new Node(data);
            }
            else
            {
                last = last.next = new Node(data);
            }
            length++;
        }

        public Node Dequeue()
        {
            if (IsEmpty()) return null;

            Node temp = first;
            first = first.next;
            length--;

            if (first == null)
            {
                last = null;
            }
            return temp;
        }

        public void PrintQueue()
        {
            Node current = first;
            while(current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public Node Front()
        {
            if (IsEmpty()) return null;
            return first;
        }

        public Node Rear()
        {
            if (IsEmpty()) return null;
            return last;
        }

        public object FrontValue()
        {
            return IsEmpty() ? null : first.data;
        }

        public object RearValue()
        {
            return IsEmpty() ? null : last.data;
        }

        public bool IsEmpty() { return first == null; }

        public int Size() { return length; }
    }
}