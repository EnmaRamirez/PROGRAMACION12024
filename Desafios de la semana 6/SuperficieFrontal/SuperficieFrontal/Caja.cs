using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperficieFrontal
{
    public class Caja
    {
        private double alto;
        private double largo;

        public Caja(double alto, double largo)
        {
            this.alto = alto;
            this.largo = largo;
        }
        public double SuperficieFrontal
        {
            get
            {
                return alto * largo;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja = new Caja(10, 20);
            Console.WriteLine("Superficie Frontal de la caja: " + caja.SuperficieFrontal);
        }
    }
}
