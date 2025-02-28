using System;

namespace ColasconProveedores
{
    class Program
    {
        static void Main()
        {
            IQueueService queueService = null;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(" Selección de Cola de Mensajería ");
                Console.WriteLine("1. Usar Amazon SQS");
                Console.WriteLine("2. Usar RabbitMQ");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        queueService = new AmazonSQSService();
                        break;
                    case "2":
                        queueService = new RabbitMQService();
                        break;
                    case "3":
                        Console.WriteLine("Saliendo...");
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Presione ENTER para continuar.");
                        Console.ReadLine();
                        continue;
                }

                MenuOperaciones(queueService);
            }
        }

        static void MenuOperaciones(IQueueService queueService)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n Menú de Operaciones ");
                Console.WriteLine("1. Agregar mensaje (Enqueue)");
                Console.WriteLine("2. Eliminar mensaje (Dequeue)");
                Console.WriteLine("3. Mostrar contenido de la cola");
                Console.WriteLine("4. Ver cantidad de mensajes");
                Console.WriteLine("5. Cambiar proveedor de mensajería");
                Console.Write("Seleccione una opción: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Ingrese el mensaje a agregar: ");
                        string message = Console.ReadLine();
                        queueService.Enqueue(message);
                        break;
                    case "2":
                        Console.WriteLine($"Mensaje eliminado: {queueService.Dequeue()}");
                        break;
                    case "3":
                        queueService.PrintQueue();
                        break;
                    case "4":
                        Console.WriteLine($"Mensajes en la cola: {queueService.Count()}");
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

                Console.WriteLine("\nPresione ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }
}

