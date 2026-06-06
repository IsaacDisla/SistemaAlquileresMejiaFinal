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

        public DataTable ListarClientesCombo()
        {
            return dal.ListarClientesCombo();
        }

        public void Insertar(Clientes c)
        {
            dal.InsertarCliente(c);
        }

        public void Actualizar(Clientes c)
        {
            dal.ActualizarCliente(c);
        }

        public DataTable Buscar(string buscar)
        {
            return dal.BuscarClientes(buscar);
        }

        public void Eliminar(int idCliente)
        {
            dal.EliminarCliente(idCliente);
        }

    }
}