using System.Data;
using Capa.Datos;
using Capa.Entidades;

namespace Capa.Negocios
{
    public class DetalleAlquileresBL
    {
        DetalleAlquileresDAL dal = new DetalleAlquileresDAL();

        public DataTable Listar()
        {
            return dal.ListarDetalleAlquileres();
        }

        public void Insertar(DetalleAlquileres d)
        {
            dal.InsertarDetalleAlquiler(d);
        }


        public DataTable ObtenerDetallePorAlquiler(int idAlquiler)
        {
            return dal.ObtenerDetallePorAlquiler(idAlquiler);
        }
        public void Actualizar(DetalleAlquileres d)
        {
            dal.ActualizarDetalleAlquiler(d);
        }
    }
}