Sistema de Gestión de Colas de Mensajería:
Este proyecto implementa un sistema de colas de mensajería en C#, permitiendo la selección entre dos servicios: Amazon SQS y RabbitMQ.
Características: 
Implementación de una interfaz común IQueueService para asegurar la flexibilidad y escalabilidad.
Soporte para dos tipos de colas:
Amazon SQS: Implementado con un array circular para optimizar la inserción y eliminación de mensajes.
RabbitMQ: Implementado con una lista dinámica, optimizando la memoria al eliminar mensajes.
Funcionalidades principales:
Enqueue(string message): Agrega un mensaje a la cola.
Dequeue(): Extrae y elimina el mensaje más antiguo de la cola.
IsEmpty(): Verifica si la cola está vacía.
Count(): Retorna la cantidad de mensajes en la cola.
PrintQueue(): Muestra el estado actual de la cola.
Estructura del código:
IQueueService.cs = Interfaz base para los servicios de cola.
AmazonSQSService.cs = Implementación con un array circular.
RabbitMQService.cs = Implementación con una lista dinámica.
Program.cs = Punto de entrada con menú interactivo.
