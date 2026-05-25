using Capa.Datos;
using System.Data;

namespace Capa.Negocio
{
    public class FacturaAlquilerBL
    {
        private FacturaAlquilerDAL datos = new FacturaAlquilerDAL();

        public DataTable BuscarFacturaAlquiler(int idAlquiler)
        {
            return datos.BuscarFacturaAlquiler(idAlquiler);
        }

    public DataTable MostrarTodasFacturas()
        {
            return datos.MostrarTodasFacturas();
        }
    }
}