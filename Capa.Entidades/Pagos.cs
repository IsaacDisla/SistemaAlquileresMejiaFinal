using System;

namespace Capa.Entidades
{
    public class Pagos
    {
        public int Id_Pago { get; set; }

        public int Id_Alquiler { get; set; }

        public DateTime Fecha_Pago { get; set; }

        public string Metodo_Pago { get; set; }

        public decimal Monto_Pagado { get; set; }

        public string Estado { get; set; }
    }
}