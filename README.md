# Implementación de Colas en C#

## Descripción
Este proyecto implementa un sistema de atención de clientes utilizando una cola personalizada en C#. La cola está implementada mediante una estructura de datos personalizada (`Cola`), basada en una lista enlazada.

El sistema permite gestionar la llegada y atención de clientes en una fila, mostrando el estado actual de la cola y ofreciendo una interfaz de consola interactiva.

## Características
- Implementación de una cola personalizada utilizando nodos enlazados.
- Funcionalidad para agregar (enqueue) y atender (dequeue) clientes.
- Visualización del estado actual de la cola.
- Interfaz de usuario basada en consola.

## Estructura del Proyecto
```
QueuesAnton/
│── Source/
│   └── DataStructures/
│       └── Cola.cs  # Implementación de la estructura de cola
        └── Node.cs  # Implementación Nodo
│── Program.cs       # Código principal con la lógica del sistema
│── README.md        # Documentación del proyecto
```

## Instalación y Uso
### Prerrequisitos
- Tener instalado .NET SDK.
- Un entorno de desarrollo compatible con C# (como Visual Studio o VS Code).

### Ejecución
1. Clonar o descargar el repositorio.
2. Abrir una terminal en la carpeta del proyecto.
3. Compilar y ejecutar el programa:
   ```sh
   dotnet run
   ```

### Funcionalidades
Al ejecutar el programa, se presenta un menú con las siguientes opciones:

1. **Llegada de nuevo cliente**: Agrega un nuevo cliente a la cola.
2. **Atender al siguiente cliente**: Retira al cliente en la parte frontal de la cola y lo muestra como atendido.
3. **Ver estado actual de la cola**: Muestra todos los clientes en la cola y la cantidad de personas en espera.
4. **Salir**: Termina la ejecución del programa.

## Implementación de la Cola
La clase `Cola` está implementada utilizando una lista enlazada, con nodos que almacenan la información de cada cliente. Se proporciona funcionalidad para:
- `Enqueue(object data)`: Agregar un nuevo elemento a la cola.
- `Dequeue()`: Retirar y devolver el primer elemento de la cola.
- `FrontValue()`: Obtener el valor del primer elemento sin eliminarlo.
- `RearValue()`: Obtener el valor del último elemento sin eliminarlo.
- `IsEmpty()`: Verificar si la cola está vacía.
- `Size()`: Obtener el tamaño actual de la cola.
- `PrintQueue()`: Imprimir el contenido de la cola en la consola.

## Ejemplo de Uso
```csharp
Cola queue = new Cola();
queue.Enqueue("Cliente 1");
queue.Enqueue("Cliente 2");
Console.WriteLine("Estado de la cola:");
queue.PrintQueue();

var atendido = queue.Dequeue();
Console.WriteLine($"Cliente atendido: {atendido.data}");
```

