using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTareas
{
    internal class ListaDeTareas
    {
        static List<string> tareas = new List<string>();
        static void Main(string[]arg)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("--------Menu de Tareas---------");
                Console.WriteLine("1.Mostrar Tareas");
                Console.WriteLine("2. Agregar Tarea");
                Console.WriteLine("3. Eliminar Tarea");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Selecciona una opcion: ");

                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        MostrarTareas();
                        break;
                    case 2:
                        AgregarTarea();
                        break;
                    case 3:
                        EliminarTarea();
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida. Selecciona una opcion valida.");
                        break;


                }
            }
              
           
        }
        static void MostrarTareas()
        {
            Console.WriteLine("\n -------Lista de Tareas-------");
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas pendientes.");
            }
            else
            {
                for (int i = 0; i < tareas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tareas[i]}");
                }
            }
            Console.WriteLine();

        }
        static void AgregarTarea()

        {
            Console.WriteLine("\n Ingresa nueva tarea: ");
            string nuevaTarea = Console.ReadLine();
            tareas.Add(nuevaTarea);
            Console.WriteLine("Tarea agregada exitosamente. \n");

        }
        static void EliminarTarea()
        {
            MostrarTareas();
            Console.WriteLine("Ingrese el numero de la tarea que desea eliminar: ");
            int indice = int.Parse(Console.ReadLine()) - 1;
            if (indice >= 0 &&indice < tareas.Count)
            {
                tareas.RemoveAt(indice);
                Console.WriteLine("Tarea eliminada exitosamente.\n");

            }
            else
            {
                Console.WriteLine("Indice de la tarea invalido.\n");
            }
        }
    }

}
