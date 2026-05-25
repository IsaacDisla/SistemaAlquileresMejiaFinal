using System.Data;
using Capa.Datos;
using Capa.Entidades;

namespace Capa.Negocios
{
    public class PagosBL
    {
        PagosDAL dal = new PagosDAL();

        public DataTable Listar()
        {
            return dal.ListarPagos();
        }

        public void Insertar(Pagos p)
        {
            dal.InsertarPago(p);
        }

        public void Actualizar(Pagos p)
        {
            dal.ActualizarPago(p);
        }
    }
}