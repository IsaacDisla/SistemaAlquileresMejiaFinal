using System;

namespace Capa.Entidades
{
    public class Alquileres
    {
        public int Id_Alquiler { get; set; }

        public int Id_Cliente { get; set; }

        public int Id_Usuario { get; set; }

        public DateTime Fecha_Inicio { get; set; }

        public string Estado_Alquiler { get; set; }
    }
}