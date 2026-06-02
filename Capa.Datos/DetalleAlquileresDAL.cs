using Capa.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Capa.Datos
{
    public class DetalleAlquileresDAL
    {
        private string conexion = "Server=.;Database=Alquiler_VehiculosMJ;Trusted_Connection=True;";

        public DataTable ListarDetalleAlquileres()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_ListarDetalleAlquileres", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public void InsertarDetalleAlquiler(DetalleAlquileres detalle)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarDetalleAlquiler", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Alquiler", detalle.Id_Alquiler);
                cmd.Parameters.AddWithValue("@Id_Vehiculo", detalle.Id_Vehiculo);
                cmd.Parameters.AddWithValue("@Fecha_Entrega_Esperada", detalle.Fecha_Entrega_Esperada);
                cmd.Parameters.AddWithValue("@Precio_Dia", detalle.Precio_Dia);
                cmd.Parameters.AddWithValue("@Dias_Alquilados", detalle.Dias_Alquilados);
                cmd.Parameters.AddWithValue("@Subtotal", detalle.Subtotal);
                cmd.Parameters.AddWithValue("@Kilometraje_Salida", detalle.Kilometraje_Salida);
                cmd.Parameters.AddWithValue("@Combustible_Salida", detalle.Combustible_Salida);
                cmd.Parameters.AddWithValue("@Estado_Salida", detalle.Estado_Salida);
                cmd.Parameters.AddWithValue("@Estado", detalle.Estado);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerDetallePorAlquiler(int idAlquiler)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    string query = @"
            SELECT
                d.Id_Vehiculo,
                v.Marca + ' ' + v.Modelo AS Vehiculo,
                d.Fecha_Entrega_Esperada AS Fecha_Entrega,
                d.Precio_Dia,
                d.Dias_Alquilados AS Dias,
                d.Subtotal,
                d.Kilometraje_Salida AS Kilometraje,
                d.Combustible_Salida AS Combustible,
                d.Estado_Salida
            FROM Detalle_Alquileres d
            INNER JOIN Vehiculos v
                ON d.Id_Vehiculo = v.Id_Vehiculo
            WHERE d.Id_Alquiler = @IdAlquiler";

                    SqlDataAdapter da =
                        new SqlDataAdapter(query, cn);

                    da.SelectCommand.Parameters.AddWithValue(
                        "@IdAlquiler", idAlquiler);

                    da.Fill(dt);
                }
            }
            catch
            {
                throw;
            }

            return dt;
        }

        public void ActualizarDetalleAlquiler(DetalleAlquileres detalle)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarDetalleAlquiler", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Detalle", detalle.Id_Detalle);
                cmd.Parameters.AddWithValue("@Id_Alquiler", detalle.Id_Alquiler);
                cmd.Parameters.AddWithValue("@Id_Vehiculo", detalle.Id_Vehiculo);
                cmd.Parameters.AddWithValue("@Fecha_Entrega_Esperada", detalle.Fecha_Entrega_Esperada);
                cmd.Parameters.AddWithValue("@Precio_Dia", detalle.Precio_Dia);
                cmd.Parameters.AddWithValue("@Dias_Alquilados", detalle.Dias_Alquilados);
                cmd.Parameters.AddWithValue("@Subtotal", detalle.Subtotal);
                cmd.Parameters.AddWithValue("@Kilometraje_Salida", detalle.Kilometraje_Salida);
                cmd.Parameters.AddWithValue("@Combustible_Salida", detalle.Combustible_Salida);
                cmd.Parameters.AddWithValue("@Estado_Salida", detalle.Estado_Salida);
                cmd.Parameters.AddWithValue("@Estado", detalle.Estado);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}