using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class DashboardDAL
    {

        private string conexion = "Server=.;Database=Alquiler_VehiculosMJ;Trusted_Connection=True;";

        private string ObtenerValor(string procedimiento)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand(procedimiento, cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                object resultado = cmd.ExecuteScalar();

                return resultado == null ? "0" : resultado.ToString();
            }
        }

        public string VehiculosDisponibles()
        {
            return ObtenerValor("sp_DashboardVehiculosDisponibles");
        }

        public string VehiculosRentados()
        {
            return ObtenerValor("sp_DashboardVehiculosRentados");
        }

        public string VehiculosMantenimiento()
        {
            return ObtenerValor("sp_DashboardVehiculosMantenimiento");
        }

        public string AlquileresActivos()
        {
            return ObtenerValor("sp_DashboardAlquileresActivos");
        }

        public string PagosPendientes()
        {
            return ObtenerValor("sp_DashboardPagosPendientes");
        }

        public string IngresosMes()
        {
            return ObtenerValor("sp_DashboardIngresosMes");
        }
    }
}

