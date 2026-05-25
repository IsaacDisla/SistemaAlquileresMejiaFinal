using System.Data;
using Capa.Datos;
using Capa.Entidades;

namespace Capa.Negocios
{
    public class UsuariosBL
    {
        UsuariosDAL dal = new UsuariosDAL();

        public DataTable Listar()
        {
            return dal.ListarUsuarios();
        }

        public void Insertar(Usuarios u)
        {
            dal.InsertarUsuario(u);
        }

        public void Actualizar(Usuarios u)
        {
            dal.ActualizarUsuario(u);
        }

        public DataTable Login(string usuario, string clave)
        {
            return dal.Login(usuario, clave);
        }
    }
}