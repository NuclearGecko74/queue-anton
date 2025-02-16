using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QueuesAnton.Source.DataStructures;

namespace QueuesAnton
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola queue = new Cola(5);
            queue.Enqueue(2);
            queue.Dequeue();
            queue.PrintQueue();
        }
    }
}