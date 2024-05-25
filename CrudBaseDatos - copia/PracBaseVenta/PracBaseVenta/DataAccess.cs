using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Dapper;



namespace PracBaseVenta
{
    public class DataAccess
    {
        public const string CONNECTION_STRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\enma2\\OneDrive\\Escritorio\\TAREAS DE PROGRAMACION12024\\CrudBaseDatos\\PracBaseVenta\\PracBaseVenta\\Database1.mdf\";Integrated Security=True";
        public const string CADENA_SQL_SERVER = "Server=ENMITA\\SQLEXPRESS;Integrated Security=true;Initial Catalog=DBVenta";

        public List<Venta> GetAllAdoNet()
        {
            List<Venta> ventas = new List<Venta>();
            try
            {
                SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
                string query = "SELECT id, clientes, cantidades, precio FROM Venta";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Venta a = new Venta
                    {
                        Id = reader.GetInt32(0),
                        Cliente = reader.GetString(1),
                        Cantidad = reader.GetInt32(2),
                        Precio = reader.GetDecimal(3)
                    };
                    ventas.Add(a);


                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ventas;// Forma de ADO.NET

        }
        public List<Venta> GetAllDapper()
        {
            List<Venta> ventas = new List<Venta>();
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = "SELECT id, clientes, cantidades, precio FROM Venta";
                ventas = conn.Query<Venta>(query).ToList();
                conn.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ventas;

        }

       
    }
}

    
