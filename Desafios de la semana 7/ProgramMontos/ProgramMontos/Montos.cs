using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramMontos
{
    internal class Montos
    {
        public static void Main(string[] args)
        {
            //Areglo bidimensional
            int[,] compras = {
            {20, 10, 30, 25, 10}, // Cliente 1
            {80, 200, 150, 300, 100}, // Cliente 2
            {100, 300, 250, 400, 900}, // Cliente 3
            {110, 80, 100, 600, 1400},  // Cliente 4
            {70, 140, 200, 300, 1200}   // Cliente 5
        };

            CalcularDescuentos(compras);
        }

        public static void CalcularDescuentos(int[,] compras)
        {
            for (int i = 0; i < compras.GetLength(0); i++)
            {
                int totalCompras = 0;
                for (int j = 0; j < compras.GetLength(1); j++)
                {
                    totalCompras += compras[i, j];
                }

                double descuento = 0.0;
                if (totalCompras >= 100 && totalCompras <= 1000)
                {
                    descuento = totalCompras * 0.1;
                }
                else if (totalCompras > 1000)
                {
                    descuento = totalCompras * 0.2;
                }

                Console.WriteLine($"Cliente {i + 1}: Total de compras = ${totalCompras}, Descuento = ${descuento}");
            }
        }
    }


}

