using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesAnton.Source.DataStructures
{
    class Node
    {
        public object data;
        public Node next;

        public Node(object data)
        {
            this.data = data;
            this.next = null;
        }

        public Node(object data, Node next)
        {
            this.data = data;
            this.next = next;
        }
    }
}
