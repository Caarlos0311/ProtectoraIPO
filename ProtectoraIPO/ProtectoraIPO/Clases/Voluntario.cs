using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectoraIPO.Clases
{
    public class Voluntario
    {
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public string Correo { set; get; }
        public string Dni { set; get; }
        public string Telefono { set; get; }
        public Uri Foto { set; get; }
        public string HorarioDisponibilidad { set; get; }
        public string ZonaActuacion { set; get; }
        public bool ConocimientosVeterinarios { set; get; }

        public Voluntario(string nombre, string apellidos, string correo, string dni, string telefono, Uri foto,
            string horarioDisponibilidad, string zonaActuacion, bool conocimientosVeterinarios)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Correo = correo;
            Dni = dni;
            Telefono = telefono;
            Foto = foto;
            HorarioDisponibilidad = horarioDisponibilidad;
            ZonaActuacion = zonaActuacion;
            ConocimientosVeterinarios = conocimientosVeterinarios;
        }

        public void actualizar(string nombre, string apellidos, string correo, string dni, string telefono, Uri foto,
            string horarioDisponibilidad, string zonaActuacion, bool conocimientosVeterinarios)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Correo = correo;
            Dni = dni;
            Telefono = telefono;
            Foto = foto;
            HorarioDisponibilidad = horarioDisponibilidad;
            ZonaActuacion = zonaActuacion;
            ConocimientosVeterinarios = conocimientosVeterinarios;
        }
    }
}
