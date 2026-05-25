using System.Data;
using System.Data.SqlClient;
using Capa.Entidades;

namespace Capa.Datos
{
    public class EntregaVehiculoDAL
    {
        private string conexion = "Server=.;Database=Alquiler_VehiculosMJ;Trusted_Connection=True;";

        public DataTable ListarEntregas()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_ListarEntregasVehiculos", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public void InsertarEntrega(EntregaVehiculo entrega)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarEntregaVehiculo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Detalle", entrega.Id_Detalle);
                cmd.Parameters.AddWithValue("@Fecha_Entrega_Real", entrega.Fecha_Entrega_Real);
                cmd.Parameters.AddWithValue("@Kilometraje_Entrada", entrega.Kilometraje_Entrada);
                cmd.Parameters.AddWithValue("@Combustible_Entrada", entrega.Combustible_Entrada);
                cmd.Parameters.AddWithValue("@Estado_Entrada", entrega.Estado_Entrada);
                cmd.Parameters.AddWithValue("@Observaciones", entrega.Observaciones);
                cmd.Parameters.AddWithValue("@Dias_Retraso", entrega.Dias_Retraso);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarEntrega(EntregaVehiculo entrega)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarEntregaVehiculo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Entrega", entrega.Id_Entrega);
                cmd.Parameters.AddWithValue("@Id_Detalle", entrega.Id_Detalle);
                cmd.Parameters.AddWithValue("@Fecha_Entrega_Real", entrega.Fecha_Entrega_Real);
                cmd.Parameters.AddWithValue("@Kilometraje_Entrada", entrega.Kilometraje_Entrada);
                cmd.Parameters.AddWithValue("@Combustible_Entrada", entrega.Combustible_Entrada);
                cmd.Parameters.AddWithValue("@Estado_Entrada", entrega.Estado_Entrada);
                cmd.Parameters.AddWithValue("@Observaciones", entrega.Observaciones);
                cmd.Parameters.AddWithValue("@Dias_Retraso", entrega.Dias_Retraso);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}