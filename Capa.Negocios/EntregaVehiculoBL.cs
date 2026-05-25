using System.Data;
using Capa.Datos;
using Capa.Entidades;

namespace Capa.Negocios
{
    public class EntregaVehiculoBLL
    {
        EntregaVehiculoDAL dal = new EntregaVehiculoDAL();

        public DataTable Listar()
        {
            return dal.ListarEntregas();
        }

        public void Insertar(EntregaVehiculo e)
        {
            dal.InsertarEntrega(e);
        }

        public void Actualizar(EntregaVehiculo e)
        {
            dal.ActualizarEntrega(e);
        }
    }
}