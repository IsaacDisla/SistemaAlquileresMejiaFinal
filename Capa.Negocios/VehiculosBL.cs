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
    }
}