using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public static class SesionActual
    {
        public static string NombreUsuario { get; set; }
        public static int RolId { get; set; }
        public static string correo { get; set; }
    }
}
