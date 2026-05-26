using System.Data;
using System.Data.SqlClient;

namespace Capa.Datos
{
    public class BackupDAL
    {
        private string conexion =
        "Server=.;Database=Alquiler_VehiculosMJ;Trusted_Connection=True;";

        public void CrearBackup()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd =
                new SqlCommand("sp_BackupAutomatico", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void RestaurarBackup(string ruta)
        {
            using (SqlConnection cn =
            new SqlConnection("Server=.;Database=master;Trusted_Connection=True;"))
            {
                SqlCommand cmd =
                new SqlCommand("sp_RestaurarBackup", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Ruta", ruta);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}