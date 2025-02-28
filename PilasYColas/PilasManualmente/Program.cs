namespace PilasManualmente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila(10);
            Console.WriteLine(pila);
            pila.Push(10);
            pila.Push(20);
            pila.Push(30);
            pila.Push(40);
            pila.Push(50);
            Console.WriteLine($"Número de elementos en la pila: {pila.ContarElementos()}");
            Console.WriteLine($"Elemento en el tope: {pila.Peek()}");


            pila.Pop();
            pila.Pop();
            Console.WriteLine($"Elemento en el tope: {pila.Peek()}");

            Console.WriteLine($"La pila está vacía: {pila.EstaVacia()}");
            pila.Pop();
            pila.Pop();
            Console.WriteLine($"Número de elementos en la pila: {pila.ContarElementos()}");
        }
    }
}
