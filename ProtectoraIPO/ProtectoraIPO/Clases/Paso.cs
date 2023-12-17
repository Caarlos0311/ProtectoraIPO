using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectoraIPO.Clases
{
    public class Paso
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Uri Foto { get; set; }

        public Paso(int id, string descripcion, Uri foto)
        {
            Id = id;
            Descripcion = descripcion;
            Foto = foto;
        }
    }
}
