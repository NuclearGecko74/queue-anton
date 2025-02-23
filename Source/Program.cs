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
            Cola queue = new Cola();

            while (true)
            {
                Console.Clear();
                PrintMenu();

                Console.Write("\nSelecciona una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": // Opción para agregar un nuevo cliente a la cola.
                        Console.Clear();
                        Console.WriteLine("=== LLEGADA DE NUEVO CLIENTE ===");
                        Console.Write("Ingrese el nombre del cliente: ");
                        string cliente = Console.ReadLine();
                        queue.Enqueue(cliente);
                        Console.WriteLine($"\nCliente '{cliente}' se ha agregado a la cola.\n");
                        PrintQueueState(queue);
                        Pause();
                        break;

                    case "2": // Opción para atender al siguiente cliente en la cola.
                        Console.Clear();
                        Console.WriteLine("=== ATENDER CLIENTE ===");
                        var atendido = queue.Dequeue();
                        if (atendido == null)
                        {
                            Console.WriteLine("\nNo hay clientes en la cola para atender.\n");
                        }
                        else
                        {
                            Console.WriteLine($"\nSe atendió al cliente: {atendido.data}\n");
                        }
                        PrintQueueState(queue);
                        Pause();
                        break;

                    case "3": // Opción para mostrar el estado actual de la cola.
                        Console.Clear();
                        Console.WriteLine("=== ESTADO DE LA COLA ===");
                        PrintQueueState(queue);
                        Pause();
                        break;

                    case "4": // Opción para salir del programa.
                        Console.Clear();
                        Console.WriteLine("Saliendo del sistema de atención...");
                        return;

                    default: // Mensaje de error si la opción ingresada no es válida.
                        Console.Clear();
                        Console.WriteLine("Opción no válida. Intenta de nuevo.\n");
                        Pause();
                        break;
                }
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("    SISTEMA DE ATENCIÓN DE CLIENTES  ");
            Console.WriteLine("=====================================");
            Console.WriteLine("1. Llegada de nuevo cliente");
            Console.WriteLine("2. Atender al siguiente cliente");
            Console.WriteLine("3. Ver estado actual de la cola");
            Console.WriteLine("4. Salir");
            Console.WriteLine("=====================================");
        }

        static void PrintQueueState(Cola queue)
        {
            if (queue.IsEmpty())
            {
                Console.WriteLine("   La cola está vacía.");
            }
            else
            {
                queue.PrintQueue();
                Console.WriteLine($"\n   Total de clientes en espera: {queue.Size()}");
            }
        }

        static void Pause()
        {
            Console.WriteLine("\nPresiona una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
