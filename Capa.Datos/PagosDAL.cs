using System.Data;
using System.Data.SqlClient;
using Capa.Entidades;

namespace Capa.Datos
{
    public class PagosDAL
    {
        private string conexion = "Server=.;Database=Alquiler_VehiculosMJ;Trusted_Connection=True;";

        public DataTable ListarPagos()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_ListarPagos", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public void InsertarPago(Pagos pago)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Alquiler", pago.Id_Alquiler);
                cmd.Parameters.AddWithValue("@Fecha_Pago", pago.Fecha_Pago);
                cmd.Parameters.AddWithValue("@Metodo_Pago", pago.Metodo_Pago);
                cmd.Parameters.AddWithValue("@Monto_Pagado", pago.Monto_Pagado);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarPago(Pagos pago)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Pago", pago.Id_Pago);
                cmd.Parameters.AddWithValue("@Id_Alquiler", pago.Id_Alquiler);
                cmd.Parameters.AddWithValue("@Fecha_Pago", pago.Fecha_Pago);
                cmd.Parameters.AddWithValue("@Metodo_Pago", pago.Metodo_Pago);
                cmd.Parameters.AddWithValue("@Monto_Pagado", pago.Monto_Pagado);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}