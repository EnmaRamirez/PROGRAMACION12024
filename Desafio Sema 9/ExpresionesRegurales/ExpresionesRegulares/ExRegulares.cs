using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpresionesRegulares
{
    internal class ExRegulares
    {
        static void Main()
        {
            string texto = "Este es mi correo electrónico: enma_ramirez.25@gmail.com. Por favor envíeme un correo con sus comentarios.";
            string[] direccionesEmail = ExtraerDireccionesEmail(texto);

            Console.WriteLine("Direcciones de correo electrónico encontradas:");
            foreach (string direccion in direccionesEmail)
            {
                Console.WriteLine(direccion);
            }
        }

        static string[] ExtraerDireccionesEmail(string texto)
        {
            // Expresión regular para encontrar direcciones de correo electrónico
            string patron = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";

            // Buscar coincidencias en el texto
            MatchCollection coincidencias = Regex.Matches(texto, patron);

            // Extraer direcciones encontradas
            string[] direcciones = new string[coincidencias.Count];
            for (int i = 0; i < coincidencias.Count; i++)
            {
                direcciones[i] = coincidencias[i].Value;
            }

            return direcciones;
        }
    }
}
