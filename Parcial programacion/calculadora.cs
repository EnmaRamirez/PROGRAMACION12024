using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class calculadora
    {
        public int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;

        }
        public int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;

        }
        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;

        }
        public int Dividir(int numero1, int numero2)
        {
            if (numero2 != 0)
            {
                return numero1 / numero2;
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir por cero: ");
                return 0;
            }

        }
    }
    class Program
    {
        static void Main()
        {
            calculadora MisOperacionesMatematicas = new calculadora();
            int numero1 = 46;
            int numero2 = 80;

            Console.WriteLine($"Suma:{MisOperacionesMatematicas.Sumar(numero1, numero2)}");
            Console.WriteLine($"Resta:{MisOperacionesMatematicas.Restar(numero1, numero2)}");
            Console.WriteLine($"Multiplicacion:{MisOperacionesMatematicas.Multiplicar(numero1, numero2)}");
            Console.WriteLine($"Divicion:{MisOperacionesMatematicas.Dividir(numero1, numero2)}");

        }
    }



}


    


    

