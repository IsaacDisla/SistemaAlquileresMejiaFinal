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

        public DataTable ListarDetallesEntregados()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "sp_ListarDetallesEntregados",
                    cn
                );

                da.SelectCommand.CommandType =
                    CommandType.StoredProcedure;

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public DataTable ListarDetallesParaCargos()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlDataAdapter da =
                    new SqlDataAdapter("sp_ListarDetallesParaCargos", cn);

                da.SelectCommand.CommandType =
                    CommandType.StoredProcedure;

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

        public void ActualizarCargoAdicional(CargosAdicionales cargo)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarCargoAdicional", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Cargo", cargo.Id_Cargo);
                cmd.Parameters.AddWithValue("@Fecha", cargo.Fecha);
                cmd.Parameters.AddWithValue("@Descripcion", cargo.Descripcion);
                cmd.Parameters.AddWithValue("@Monto", cargo.Monto);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarCargoAdicional(int idCargo)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarCargoAdicional", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Cargo", idCargo);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}