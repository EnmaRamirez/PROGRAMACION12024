using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MiCrud
{
    public class DataAccess
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DBMi_BaseAlumnos"].ConnectionString;

        public static DataTable GetUsuarios()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT UsuarioID, Nombre FROM Usuarios", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetAlumnos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Alumnos", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static void InsertAlumno(string nombre, string telefono, string grado, int usuarioID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Alumnos (Nombre, Telefono, Grado, UsuarioID) VALUES (@Nombre, @Telefono, @Grado, @UsuarioID)", conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Grado", grado);
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateAlumno(int carnet, string nombre, string telefono, string grado, int usuarioID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Alumnos SET Nombre = @Nombre, Telefono = @Telefono, Grado = @Grado, UsuarioID = @UsuarioID WHERE Carnet = @Carnet", conn);
                cmd.Parameters.AddWithValue("@Carnet", carnet);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Grado", grado);
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteAlumno(int carnet)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Alumnos WHERE Carnet = @Carnet", conn);
                cmd.Parameters.AddWithValue("@Carnet", carnet);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
