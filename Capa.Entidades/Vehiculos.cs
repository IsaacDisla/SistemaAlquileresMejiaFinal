using System;

namespace Capa.Entidades
{
    public class Vehiculos
    {
        public int Id_Vehiculo { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Año { get; set; }

        public string Placa { get; set; }

        public string Color { get; set; }

        public int Kilometraje { get; set; }

        public decimal Precio_Dia { get; set; }

        public string Estado_Vehiculo { get; set; }
    }
}