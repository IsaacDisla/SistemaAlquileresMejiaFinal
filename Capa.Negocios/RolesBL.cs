using System.Data;
using Capa.Datos;
using Capa.Entidades;

namespace Capa.Negocios
{
    public class RolesBL
    {
        RolesDAL dal = new RolesDAL();

        public DataTable Listar()
        {
            return dal.ListarRoles();
        }

        public void Insertar(Roles rol)
        {
            dal.InsertarRol(rol);
        }

        public void Actualizar(Roles rol)
        {
            dal.ActualizarRol(rol);
        }

        public DataTable ReporteIngresosPorMes()
        {
            ReportesDAL obj = new ReportesDAL();
            return obj.ReporteIngresosPorMes();
        }
    }
}