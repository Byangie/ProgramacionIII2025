using System.Drawing;

namespace ColasManualmente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colas cola = new Colas(5);
            cola.push(10);
            cola.push(20);
            cola.push(30);
            cola.push(40);
            cola.push(50);

            Console.WriteLine("La cola esta llena: " + cola.Estallena());
            Console.WriteLine($"La cantidad de elementos es: {cola.ContarElementos()}");
            Console.WriteLine("Elemento en el inicio " + cola.Frente());


            cola.pop();
            cola.pop();
            Console.WriteLine("La cola está vacía " + cola.EstaVacia());
            Console.WriteLine($"La cantidad de elementos es: {cola.ContarElementos()}");

            cola.pop();
            cola.pop();
            Console.WriteLine("La cola esta vacía:" + cola.EstaVacia());
        }
    }
}
