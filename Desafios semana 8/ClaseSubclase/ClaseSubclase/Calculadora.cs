using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseSubclase
{
    public class Calculadora
    {
        //Mis atributos 
        public string Marca { get; set; }
        public string Serie { get; set; }

        // Metodos
        public double Sumar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }
        public double Restar(double numero1, double numero2)
        {
            return numero1 - numero2;
        }
        public double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }
        public double Dividir(double numero1, double numero2)
        {
            if (numero2 == 0)
            {
                Console.WriteLine("Error: No se divide por cero");
                return 0;
            }
            return numero1 / numero2;


        }
    }
   
}
