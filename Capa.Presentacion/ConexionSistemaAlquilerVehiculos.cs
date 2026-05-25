using System.Data.SqlClient;

namespace Capa.Presentacion
{
    public class ConexionSistemaAlquilerVehiculos
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(
                "Server=localhost;Database=Alquiler_VehiculosMJ;Integrated Security=True"
            );

            return cn;
        }
    }
}