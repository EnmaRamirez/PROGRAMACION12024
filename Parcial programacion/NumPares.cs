using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numpareseimpares
{
    internal class NumPares
    {
        internal class paresImpares
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Introduce Los numeros:");
                int CantidadNumeros = int.Parse(Console.ReadLine());

                int[] numeros = new int[CantidadNumeros];

                for (int i = 0; i < CantidadNumeros; i++)
                {
                    Console.WriteLine("Introduce el numero:");
                    numeros[i] = int.Parse(Console.ReadLine());

                }
                int cantidadPares = 0, cantidadImpares = 0;
                int sumaPares = 0, sumaImpares = 0;

                foreach (int numero in numeros)
                {
                    if (numero % 2 == 0)
                    {
                        cantidadPares++;
                        sumaPares += numero;
                    }
                    else
                    {
                        cantidadImpares++;
                        sumaImpares += numero;
                    }
                }
                Console.WriteLine($"Cantidad de numeros pares:{cantidadPares}");
                Console.WriteLine($"Cantidad de numeros Impares:{cantidadImpares}");
                Console.WriteLine($"Siuma de pares:{sumaPares}");
                Console.WriteLine($"DSuma de impares:{sumaImpares}");
            }
        }
    }
}