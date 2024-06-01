using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAutoyClaseBMW
{
    public class Auto
    {
        //Almacenamiento de las reparticiones
        protected List<string> reparticiones = new List<string>();

        // Metodo para agregar una reparacion a la lista
        public void AgregarReparacion(string reparacion)
        {
            reparticiones.Add(reparacion);
        }
        //Metodo en historial de reparaciones
        public virtual void HistoriaDeReparaciones()
        {
            Console.WriteLine("Historial de Reparaciones:");
            foreach (var reparacion in reparticiones)
            {
                Console.WriteLine(reparacion);
            }
        }

    }
    
}
