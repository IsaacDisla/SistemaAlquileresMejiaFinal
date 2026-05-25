using System.Data.SqlClient;

namespace Capa.Datos
{
    public class Conexion
    {
        public static SqlConnection cn = new SqlConnection(
            "Server=.;Database=Alquiler_VehiculosMJ;Integrated Security=true");
}