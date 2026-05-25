using Capa.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Capa.Datos
{
    public class RolesDAL
    {
        private string conexion = "Server=.;Database=Alquiler_VehiculosMJ;Trusted_Connection=True;";

        public DataTable ListarRoles()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_ListarRoles", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public void InsertarRol(Roles rol)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarRol", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre_Rol", rol.Nombre_Rol);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarRol(Roles rol)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarRol", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Rol", rol.Id_Rol);
                cmd.Parameters.AddWithValue("@Nombre_Rol", rol.Nombre_Rol);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}