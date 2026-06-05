using System.Data;
using Capa.Datos;
using Capa.Entidades;

namespace Capa.Negocios
{
    public class AlquileresBL
    {
        AlquileresDAL dal = new AlquileresDAL();

        public DataTable Listar()
        {
            return dal.ListarAlquileres();
        }

        public int InsertarAlquiler(Alquileres alquiler)
        {
            AlquileresDAL dal = new AlquileresDAL();

            return dal.InsertarAlquiler(alquiler);
        }

        public void Actualizar(Alquileres a)
        {
            dal.ActualizarAlquiler(a);
        }

        public DataTable BuscarAlquileres(string buscar)
        {
            return dal.BuscarAlquileres(buscar);
        }
    }
}