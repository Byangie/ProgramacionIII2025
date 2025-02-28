using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasManualmente
{
    internal class Colas
    {
        private int[] elementos;
        private int frente;
        private int final;
        private int capacidad;
        private int cantidad;

        public Colas(int capacidad)
        {
            this.capacidad = capacidad;
            elementos = new int[capacidad];
            frente = 0;
            final = -1;
            cantidad = 0;
        }

        //encolar
        public void push(int elemento)
        {
            if (cantidad == capacidad)
            {
                Console.WriteLine("Eror: La cola está llena");
                return;
            }

            final = (final + 1) % capacidad;
            elementos[final] = elemento;
            cantidad++;
            Console.WriteLine($"Push {elemento}");

        }

        //desencolar
        public int pop()
        {
            if (cantidad == 0)
            {
                Console.WriteLine("Error: La cola está vacía");
                return -1;
            }

            int elemento = elementos[frente];
            frente = (frente + 1) % capacidad;
            cantidad--;
            Console.WriteLine($"Pop: {elemento}");
            return elemento;
        }

        //peek
        public int Frente()
        {
            if (cantidad == 0)
            {
                Console.WriteLine("Error: La cola está vacía");
                return -1;
            }
            return elementos[frente];
        }
        public bool EstaVacia()
        {
            return cantidad == 0;
        }
        public bool Estallena()
        {
            return cantidad == capacidad;
        }
        public int ContarElementos()
        {
            return cantidad;
        }
    }
}
