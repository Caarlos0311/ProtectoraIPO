using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectoraIPO.Clases
{
    public class Padrino
    {
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public string Telefono { set; get; }
        public double AportacionMensual { set; get; }
        public int FormaPago { set; get; }
        public string NumeroCuenta { set; get; }
        public DateTime FechaComienzoApadrinamiento { set; get; }

        public Padrino(string nombre, string apellidos, string telefono, double aportacionMensual, int formaPago, string numeroCuenta, DateTime fechaComienzoApadrinamiento)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
            AportacionMensual = aportacionMensual;
            FormaPago = formaPago;
            NumeroCuenta = numeroCuenta;
            FechaComienzoApadrinamiento = fechaComienzoApadrinamiento;
        }

        public void actualizar(string nombre, string apellidos, string telefono, double aportacionMensual, int formaPago, string numeroCuenta, DateTime fechaComienzoApadrinamiento)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
            AportacionMensual = aportacionMensual;
            FormaPago = formaPago;
            NumeroCuenta = numeroCuenta;
            FechaComienzoApadrinamiento = fechaComienzoApadrinamiento;
        }
    }
}