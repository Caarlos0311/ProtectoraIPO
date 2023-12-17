using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectoraIPO.Clases
{
    public class Preferencia
    {
        public bool Scroll { get; set; }
        public int TBotones { get; set; }
        public int TFuentes { get; set; }
        public int TIconos { get; set; }
        public bool Tema { get; set; }
        public bool Gif { get; set; }
        public bool Sonidos { get; set; }

        public Preferencia(bool scroll, int tBotones, int tFuentes, int tIconos, bool tema, bool gif, bool sonidos)
        {
            Scroll = scroll;
            TBotones = tBotones;
            TFuentes = tFuentes;
            TIconos = tIconos;
            Tema = tema;
            Gif = gif;
            Sonidos = sonidos;
        }
    }
}
