using System;

namespace Capa.Entidades
{
    public class CargosAdicionales
    {
        public int Id_Cargo { get; set; }

        public int Id_Detalle { get; set; }

        public DateTime Fecha { get; set; }

        public string Descripcion { get; set; }

        public decimal Monto { get; set; }
    }
}