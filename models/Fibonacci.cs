using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Gupy.models
{
    public class Fibonacci
    {
        public int Numero { get; set; }

    public Fibonacci(int numero)
    {
        Numero = numero;
    }

    public bool PertenceFibonacci()
    {
        int a = 0;
        int b = 1;

        if (Numero == a || Numero == b)
        {
            return true;
        }

        int proximo = a + b;

        while (proximo <= Numero)
        {
            if (proximo == Numero)
            {
                return true;
            }

            a = b;
            b = proximo;
            proximo = a + b;
        }

        return false;
    }

    public void VerificarNumero()
    {
        if (PertenceFibonacci())
        {
            Console.WriteLine($"O número {Numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {Numero} não pertence à sequência de Fibonacci.");
        }
    }
    }
}