using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalVolumenCajas
{
    public class Caja
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public double CalcularVolumen()
        {
            return Largo * Ancho * Alto;

        }
        static void Main(string[] args)
        {
            List<Caja> cajas = new List<Caja>();

            Console.WriteLine("Ingrese las dimensiones de las cajas (largo, ancho, alto):");
            while (true)
            {
                Console.WriteLine("Caja #{0}:", cajas.Count + 1);
                double largo = Convert.ToDouble(Console.ReadLine());
                double ancho = Convert.ToDouble(Console.ReadLine());
                double alto = Convert.ToDouble(Console.ReadLine());

                Caja nuevaCaja = new Caja { Largo = largo, Ancho = ancho, Alto = alto };
                cajas.Add(nuevaCaja);

                Console.WriteLine("¿Desea agregar otra caja? (si/no)");
                if (Console.ReadLine().ToLower() != "si")
                    break;
            }
            double volumenTotal = 0;
            foreach (var caja in cajas)
            {
                volumenTotal += caja.CalcularVolumen();
            }

            double volumenPromedio = volumenTotal / cajas.Count;

            Console.WriteLine("Volumen total de las cajas: " + volumenTotal);
            Console.WriteLine("Volumen promedio de las cajas: " + volumenPromedio);

        }
    }
}
