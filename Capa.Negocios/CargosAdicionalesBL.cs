using System.Data;
using Capa.Datos;
using Capa.Entidades;

namespace Capa.Negocios
{
    public class CargosAdicionalesBL
    {
        CargosAdicionalesDAL dal = new CargosAdicionalesDAL();

        public DataTable Listar()
        {
            return dal.ListarCargosAdicionales();
        }

        public DataTable ListarCargosAdicionales()
        {
            return dal.ListarCargosAdicionales();
        }

        public void Insertar(CargosAdicionales c)
        {
            dal.InsertarCargoAdicional(c);
        }

        public void InsertarCargoAdicional(CargosAdicionales cargo)
        {
            dal.InsertarCargoAdicional(cargo);
        }

        public DataTable ListarDetallesParaCargos()
        {
            return dal.ListarDetallesParaCargos();
        }

        public DataTable ListarDetallesEntregados()
        {
            return dal.ListarDetallesEntregados();
        }

        public void ActualizarCargoAdicional(CargosAdicionales cargo)
        {
            dal.ActualizarCargoAdicional(cargo);
        }

        public void EliminarCargoAdicional(int idCargo)
        {
            dal.EliminarCargoAdicional(idCargo);
        }
    }
}