using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Capa.Datos
{
    public class Conexion
    {
        // Cambia "NombreBaseDatos" por el de tu DB
        private string connectionString = "Server=LAPTOP-U66FAVEO.;Database=Alquiler_VehiculosMj;Trusted_Connection=True;";

        // Método para abrir la conexión
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                // Conexión abierta correctamente
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al conectar a la base de datos: " + ex.Message);
            }
            return conn;
        }
    }
}
