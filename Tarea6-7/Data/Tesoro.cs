using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea6_7.Data
{
    public class Tesoro
    {
        public int TesoroId { get; set; }
        public string Nombre { get; set; }
        public double Valor { get; set; }
        public double Peso { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Url { get; set; }

        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}