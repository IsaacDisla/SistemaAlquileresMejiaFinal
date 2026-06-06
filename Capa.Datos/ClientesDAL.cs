using Capa.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Capa.Datos
{
    public class ClientesDAL
    {
        private string conexion = "Server=.;Database=Alquiler_VehiculosMJ;Trusted_Connection=True;";

        public DataTable ListarClientes()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_ListarClientes", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public void InsertarCliente(Clientes cliente)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@Cedula", cliente.Cedula);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@Licencia", cliente.Licencia);
                cmd.Parameters.AddWithValue("@Nombre_Garante", cliente.Nombre_Garante);
                cmd.Parameters.AddWithValue("@Telefono_Garante", cliente.Telefono_Garante);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarCliente(Clientes cliente)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Cliente", cliente.Id_Cliente);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@Cedula", cliente.Cedula);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@Licencia", cliente.Licencia);
                cmd.Parameters.AddWithValue("@Nombre_Garante", cliente.Nombre_Garante);
                cmd.Parameters.AddWithValue("@Telefono_Garante", cliente.Telefono_Garante);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable BuscarClientes(string buscar)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlDataAdapter da =
                    new SqlDataAdapter("sp_BuscarClientes", cn);

                da.SelectCommand.CommandType =
                    CommandType.StoredProcedure;

                da.SelectCommand.Parameters.AddWithValue(
                    "@Buscar", buscar);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public void EliminarCliente(int idCliente)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Cliente", idCliente);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ListarClientesCombo()
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_ListarClientesCombo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
    }
}