using System;

namespace Capa.Entidades
{
    public class Usuarios
    {
        public int Id_Usuario { get; set; }

        public int Id_Rol { get; set; }

        public string Nombre { get; set; }

        public string Usuario { get; set; }

        public string Clave { get; set; }

        public bool Estado { get; set; }
    }
}