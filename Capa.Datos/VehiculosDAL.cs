using Capa.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Capa.Datos
{
    public class VehiculosDAL
    {
        private string conexion = "Server=.;Database=Alquiler_VehiculosMJ;Trusted_Connection=True;";

        public DataTable ListarVehiculos()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_ListarVehiculos", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public void InsertarVehiculo(Vehiculos vehiculo)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarVehiculo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Marca", vehiculo.Marca);
                cmd.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
                cmd.Parameters.AddWithValue("@Año", vehiculo.Año);
                cmd.Parameters.AddWithValue("@Placa", vehiculo.Placa);
                cmd.Parameters.AddWithValue("@Color", vehiculo.Color);
                cmd.Parameters.AddWithValue("@Kilometraje", vehiculo.Kilometraje);
                cmd.Parameters.AddWithValue("@Precio_Dia", vehiculo.Precio_Dia);
                cmd.Parameters.AddWithValue("@Estado_Vehiculo", vehiculo.Estado_Vehiculo);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarVehiculo(Vehiculos vehiculo)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarVehiculo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Vehiculo", vehiculo.Id_Vehiculo);
                cmd.Parameters.AddWithValue("@Marca", vehiculo.Marca);
                cmd.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
                cmd.Parameters.AddWithValue("@Año", vehiculo.Año);
                cmd.Parameters.AddWithValue("@Placa", vehiculo.Placa);
                cmd.Parameters.AddWithValue("@Color", vehiculo.Color);
                cmd.Parameters.AddWithValue("@Kilometraje", vehiculo.Kilometraje);
                cmd.Parameters.AddWithValue("@Precio_Dia", vehiculo.Precio_Dia);
                cmd.Parameters.AddWithValue("@Estado_Vehiculo", vehiculo.Estado_Vehiculo);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}