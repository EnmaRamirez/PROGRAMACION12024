using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAutoyClaseBMW
{
    public  class BMW : Auto
    {      //Metodo de reparar el BMW
        public void Reparar(string reparacion)
        {
            AgregarReparacion(reparacion);


            // Guardamos el historial de reparacion en un archivo de texto

            using (StreamWriter sw= File.AppendText("Historial_De_reparaciones.txt"))
            {
                sw.WriteLine(reparacion);
            }
        }
        public override void HistoriaDeReparaciones()
        {
            Console.WriteLine("Historial de Reparaciones:");
            using (StreamReader sr = new StreamReader("Historial_De_reparaciones.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            BMW miBMW= new BMW();

            miBMW.Reparar("Las llantas delanteras");
            miBMW.Reparar("Vidrio dañado");
            

            miBMW.HistoriaDeReparaciones();
        }
    }
}
