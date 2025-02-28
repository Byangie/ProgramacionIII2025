using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasManualmente
{
    internal class Pila
    {
        private int[] elementos;
        private int tope;
        private int capacidad;
        private int cantidad;

        public Pila(int capacidad)
        {
            this.capacidad = capacidad;
            elementos = new int[capacidad];
            tope = -1;
            cantidad = 0;
        }

        public void Push(int elemento)
        {
            if (tope == capacidad - 1)
            {
                Console.WriteLine("Error: La pila está llena.");
                return; //Valor de error
            }

            elementos[++tope] = elemento; //Incrementa el tope y alamacena el elemnto
            cantidad++;
            Console.WriteLine($"Push: {elemento}");
        }

        public int Pop()
        {
            if (tope == -1)
            {
                Console.WriteLine("Error: La pila está vacía");
                return -1;
            }
            int elemento = elementos[tope--]; //Obtiene el elemento y reduce el tope
            cantidad--;
            Console.WriteLine($"Pop: {elemento}");
            return elemento;
        }

        public int Peek()
        {
            if (tope == -1)
            {
                Console.WriteLine("Error: La pila está vacía");
                return -1;
            }
            return elementos[tope];
        }
        public bool EstaVacia()
        {
            return tope == -1;
        }
        public bool EstaLlena()
        {

            return tope == capacidad - 1;
        }
        public int ContarElementos()
        {
            return cantidad;
        }
    }
}
