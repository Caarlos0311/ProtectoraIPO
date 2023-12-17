using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectoraIPO.Clases
{
    public class Ayuda
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Paso[] Pasos { get; set; }

        public Ayuda(int id, string titulo, Paso[] pasos)
        {
            Id = id;
            Titulo = titulo;
            Pasos = pasos;
        }
    }
}
