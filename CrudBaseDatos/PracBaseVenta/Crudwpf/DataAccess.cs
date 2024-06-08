using Crudwpf;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracBaseAalumno

{
    public class DataAccess
    {
        public const string CONNECTION_STRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Progra2024\\CrudBaseDatos\\PracBaseVenta\\Crudwpf\\Database1.mdf;Integrated Security=True";
       // public const string CADENA_SQL_SERVER = "Server=ENMITA\\SQLEXPRESS;Integrated Security=true;Initial Catalog=DBVenta";

        public List<Alumno> GetAll()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
                string query = "SELECT id, nombres, apellidos, carnet, telefono FROM Alumno";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Alumno a = new Alumno {
                        Id = reader.GetInt32(0),
                        Nombres = reader.GetString(1),
                        Apellidos = reader.GetString(2),
                        Carnet = reader.GetString(3),
                        Telefono = reader.GetString(4)
                    };
                    alumnos.Add(a);


                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return alumnos;// Forma de ADO.NET

        }
    }
}
