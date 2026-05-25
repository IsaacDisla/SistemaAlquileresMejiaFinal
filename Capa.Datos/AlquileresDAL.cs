using Capa.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Capa.Datos
{
    public class AlquileresDAL
    {
        private string conexion = "Server=.;Database=Alquiler_VehiculosMJ;Trusted_Connection=True;";

        public DataTable ListarAlquileres()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_ListarAlquileres", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public void InsertarAlquiler(Alquileres alquiler)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarAlquiler", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Cliente", alquiler.Id_Cliente);
                cmd.Parameters.AddWithValue("@Id_Usuario", alquiler.Id_Usuario);
                cmd.Parameters.AddWithValue("@Fecha_Inicio", alquiler.Fecha_Inicio);
                cmd.Parameters.AddWithValue("@Estado_Alquiler", alquiler.Estado_Alquiler);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarAlquiler(Alquileres alquiler)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarAlquiler", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Alquiler", alquiler.Id_Alquiler);
                cmd.Parameters.AddWithValue("@Id_Cliente", alquiler.Id_Cliente);
                cmd.Parameters.AddWithValue("@Id_Usuario", alquiler.Id_Usuario);
                cmd.Parameters.AddWithValue("@Fecha_Inicio", alquiler.Fecha_Inicio);
                cmd.Parameters.AddWithValue("@Estado_Alquiler", alquiler.Estado_Alquiler);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}