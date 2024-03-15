using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedios
{
    internal class Promedios
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los puntajes de su alumno (validos entre 1 a 10), escriba 'fin' cuando termine:");

            double suma = 0;
            int contador = 0;
            bool finalizar = false;

            while (!finalizar)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "fin")
                {
                    finalizar = true;
                }
                else
                {
                    if (double.TryParse(input, out double puntaje))
                    {
                        if (puntaje >= 1 && puntaje <= 10)
                        {
                            suma += puntaje;
                            contador++;
                        }
                        else
                        {
                            Console.WriteLine("El puntaje debe estar entre 1 y 10.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Inválido. Por favor, ingrese un número válido.");
                    }
                }
            }

            if (contador > 0)
            {
                double promedio = suma / contador;
                Console.WriteLine($"El puntaje promedio del alumno es: {promedio}");
            }
            else
            {
                Console.WriteLine("No existen puntajes validos.");
            }
        }

    }
}
