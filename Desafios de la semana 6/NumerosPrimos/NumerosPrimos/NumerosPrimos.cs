using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    internal class NumerosPrimos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero entero positivo:");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero <= 1)
            {
                Console.WriteLine("El numero ingresado no es primo.");
            }
            else
            {
                bool EsPrimo = true;
                for (int i = 2; i <= numero / 2; i++)
                {
                    if (numero % i == 0)
                    {
                        EsPrimo = false;
                        break;
                    }
                }
                if (EsPrimo)
                { 
                    Console.WriteLine("El numero que ingreso es primo."); 
                }
                else
                {
                    Console.WriteLine("El numero ingresado es primo.");
                }
            }
           
        }
    }
}
