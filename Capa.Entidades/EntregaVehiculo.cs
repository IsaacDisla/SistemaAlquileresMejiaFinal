using System;

namespace Capa.Entidades
{
    public class EntregaVehiculo
    {
        public int Id_Entrega { get; set; }

        public int Id_Detalle { get; set; }

        public DateTime Fecha_Entrega_Real { get; set; }

        public int Kilometraje_Entrada { get; set; }

        public string Combustible_Entrada { get; set; }

        public string Estado_Entrada { get; set; }

        public string Observaciones { get; set; }

        public int Dias_Retraso { get; set; }
    }
}