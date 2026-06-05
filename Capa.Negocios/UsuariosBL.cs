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

        public void ActualizarUsuario(Usuarios usuario)
        {
            dal.ActualizarUsuario(usuario);
        }

        public DataTable Login(string usuario, string clave)
        {
            return dal.Login(usuario, clave);
        }

        public void Eliminar(int id)
        {
            dal.EliminarUsuario(id);
        }
    }
}