using Capa.Datos;

namespace Capa.Negocios
{
    public class BackupBLL
    {
        BackupDAL dal = new BackupDAL();

        public void HacerBackup()
        {
            dal.CrearBackup();
        }

        public void Restaurar(string ruta)
        {
            dal.RestaurarBackup(ruta);
        }
    }
}