using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio6
{
    internal class NumerosPares
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el numero entero positivo:");
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
            {
                Console.WriteLine("Ingresa un numero entero positivo:");
            }
            Console.WriteLine("Numeros pares hasta el {0}:", numero);
            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                }
            }
        }
    }
}
