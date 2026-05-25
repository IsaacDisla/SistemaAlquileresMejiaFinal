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

        public void Insertar(Alquileres a)
        {
            dal.InsertarAlquiler(a);
        }

        public void Actualizar(Alquileres a)
        {
            dal.ActualizarAlquiler(a);
        }
    }
}