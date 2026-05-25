using System;

namespace Capa.Entidades
{
    public class Clientes
    {
        public int Id_Cliente { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Cedula { get; set; }

        public string Telefono { get; set; }

        public string Licencia { get; set; }

        public string Nombre_Garante { get; set; }

        public string Telefono_Garante { get; set; }

        public bool Estado { get; set; }
    }
}