using System.Data;
using System.Data.SqlClient;

namespace Capa.Datos
{
    public class FacturaAlquilerDAL
    {
        private string conexion = "Server=.;Database=Alquiler_VehiculosMJ;Trusted_Connection=True;";

        public DataTable BuscarFacturaAlquiler(int idAlquiler)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_FacturaAlquiler", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Alquiler", idAlquiler);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
    }

    public DataTable MostrarTodasFacturas()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_ListarFacturasAlquiler", cn);

                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
    }
}