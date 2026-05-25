using System.Data;
using Capa.Datos;
using Capa.Entidades;

namespace Capa.Negocios
{
    public class CargosAdicionalesBLL
    {
        CargosAdicionalesDAL dal = new CargosAdicionalesDAL();

        public DataTable Listar()
        {
            return dal.ListarCargosAdicionales();
        }

        public void Insertar(CargosAdicionales c)
        {
            dal.InsertarCargoAdicional(c);
        }
    }
}