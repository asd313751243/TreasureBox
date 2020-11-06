using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea6_7.Data
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Color { get; set; }

        public List<Tesoro> _Tesoros { get; } = new List<Tesoro>();
    }
}
