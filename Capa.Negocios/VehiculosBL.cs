using System.Data;
using Capa.Datos;
using Capa.Entidades;

namespace Capa.Negocios
{
    public class VehiculosBL
    {
        VehiculosDAL dal = new VehiculosDAL();

        public DataTable Listar()
        {
            return dal.ListarVehiculos();
        }

        public void Insertar(Vehiculos v)
        {
            dal.InsertarVehiculo(v);
        }

        public void Actualizar(Vehiculos v)
        {
            dal.ActualizarVehiculo(v);
        }

        public DataTable ListarVehiculosDisponibles()
        {
            VehiculosDAL dal = new VehiculosDAL();

            return dal.ListarVehiculosDisponibles();
        }

        public void ActualizarEstadoVehiculo(int idVehiculo, string estado)
        {
            VehiculosDAL dal = new VehiculosDAL();

            dal.ActualizarEstadoVehiculo(idVehiculo, estado);
        }

        public void Eliminar(int idVehiculo)
        {
            dal.EliminarVehiculo(idVehiculo);
        }
        public DataTable Buscar(string buscar)
        {
            return dal.BuscarVehiculos(buscar);
        }
    }
}