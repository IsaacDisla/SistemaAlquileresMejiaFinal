using System.Data;
using System.Data.SqlClient;
using Capa.Entidades;

namespace Capa.Datos
{
    public class CargosAdicionalesDAL
    {
        private string conexion = "Server=.;Database=Alquiler_VehiculosMJ;Trusted_Connection=True;";

        public DataTable ListarCargosAdicionales()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_ListarCargosAdicionales", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public void InsertarCargoAdicional(CargosAdicionales cargo)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarCargoAdicional", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Detalle", cargo.Id_Detalle);
                cmd.Parameters.AddWithValue("@Fecha", cargo.Fecha);
                cmd.Parameters.AddWithValue("@Descripcion", cargo.Descripcion);
                cmd.Parameters.AddWithValue("@Monto", cargo.Monto);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}