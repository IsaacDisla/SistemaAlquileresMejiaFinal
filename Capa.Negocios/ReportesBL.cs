using Capa.Datos;
using System.Data;

namespace Capa.Negocios
{
    public class ReportesBL
    {
        private ReportesDAL reportesDAL =
            new ReportesDAL();

        public DataTable ReporteFacturaAlquiler(int idAlquiler)
        {
            return reportesDAL.FacturaAlquiler(idAlquiler);
        }
    }
}