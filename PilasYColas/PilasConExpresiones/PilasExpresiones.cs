﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasConExpresiones
{
    internal class PilasExpresiones
    {
        public static bool EstaBalanceado(string expresion)
        {
            Stack<char> pila = new Stack<char>();
            foreach (char c in expresion)
            {
                if (c == '(')
                {
                    pila.Push(c);
                }
                else if (c == ')')
                {
                    if (pila.Count == 0)
                    {

                        return false;
                    }
                    pila.Pop();
                }
            }
            return pila.Count == 0;
        }
    }
}
