using System;

namespace Capa.Entidades
{
    public class DetalleAlquileres
    {
        public int Id_Detalle { get; set; }

        public int Id_Alquiler { get; set; }

        public int Id_Vehiculo { get; set; }

        public DateTime Fecha_Entrega_Esperada { get; set; }

        public decimal Precio_Dia { get; set; }

        public int Dias_Alquilados { get; set; }

        public decimal Subtotal { get; set; }

        public int Kilometraje_Salida { get; set; }

        public string Combustible_Salida { get; set; }

        public string Estado_Salida { get; set; }

        public string Estado { get; set; }
    }
}