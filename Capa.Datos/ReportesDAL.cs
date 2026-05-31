using System.Data;
using System.Data.SqlClient;

namespace Capa.Datos
{
    public class ReportesDAL
    {
        private string conexion =
        "Server=.;Database=Alquiler_VehiculosMJ;Trusted_Connection=True;";

        public DataTable FacturaAlquiler(int idAlquiler)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn =
                new SqlConnection(conexion))
            {
                SqlCommand cmd =
                    new SqlCommand("sp_ReporteFacturaAlquiler", cn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(
                    "@Id_Alquiler",
                    idAlquiler);

                SqlDataAdapter da =
                    new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }
    }
}