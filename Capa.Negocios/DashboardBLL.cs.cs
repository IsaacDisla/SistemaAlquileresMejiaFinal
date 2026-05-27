using Capa.Datos;

namespace Capa.Negocio
{
    public class DashboardBLL
    {
        DashboardDAL datos = new DashboardDAL();

        public string VehiculosDisponibles()
        {
            return datos.VehiculosDisponibles();
        }

        public string VehiculosRentados()
        {
            return datos.VehiculosRentados();
        }

        public string VehiculosMantenimiento()
        {
            return datos.VehiculosMantenimiento();
        }

        public string AlquileresActivos()
        {
            return datos.AlquileresActivos();
        }

        public string PagosPendientes()
        {
            return datos.PagosPendientes();
        }

        public string IngresosMes()
        {
            return datos.IngresosMes();
        }
    }
}