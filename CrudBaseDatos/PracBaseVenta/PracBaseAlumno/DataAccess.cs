using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Dapper;

namespace PracBaseAlumno
{
    public class DataAccess
    {
        public const string CONNECTION_STRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Progra2024\\CrudBaseDatos\\PracBaseVenta\\PracBaseAlumno\\Database1.mdf;Integrated Security=True";
        public const string CADENA_SQL_SERVER = "Server=ENMITA\\SQLEXPRESS;Integrated Security=true;Initial Catalog=DBALUMNO";

        public List<Alumno> GetAllAdoNet()
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
                    Alumno a = new Alumno
                    {
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
        public List<Alumno> GetAllDapper() {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = "SELECT id, nombres, apellidos, carnet, telefono FROM Alumno";
                alumnos = conn.Query<Alumno> (query).ToList();
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return alumnos;
        }
        public int Create(Alumno alumno)
        {
            int result = 0;
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = @"INSERT INTO Alumno (id, nombres, apellidos, carnet, telefono, idCarrera)
                                              VALUES (@id, @nombres, @apellidos, @carnet, @telefono, @idCarrera) 
";
                //Para guardar, actualizar o eliminar se usa execute.
                result = conn.Execute(query, new
                {
                    id = alumno.Id,
                    nombres = alumno.Nombres,
                    apellidos = alumno.Apellidos,
                    carnet = alumno.Carnet,
                    telefono = alumno.Telefono
                    
                });
                conn.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }

            return result;
        }
        public Alumno GetById(int idAlumno)
        {
            Alumno alumno = new Alumno();
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = "SELECT id, nombres, apellidos, carnet, telefono, idCarrera FROM Alumno WHERE id=@id";
                alumno = conn.QuerySingle<Alumno>(query, new { id = idAlumno });
                conn.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return alumno;
        }
    }
}
