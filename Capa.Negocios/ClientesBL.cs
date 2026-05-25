using System.Data;
using Capa.Datos;
using Capa.Entidades;

namespace Capa.Negocios
{
    public class ClientesBL
    {
        ClientesDAL dal = new ClientesDAL();

        public DataTable Listar()
        {
            return dal.ListarClientes();
        }

        public void Insertar(Clientes c)
        {
            dal.InsertarCliente(c);
        }

        public void Actualizar(Clientes c)
        {
            dal.ActualizarCliente(c);
        }
    }
}