using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectoraIPO.Clases
{
    public class Socio
    {
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public string Correo { set; get; }
        public string TitularCuenta { set; get; }
        public string NumeroCuenta { set; get; }
        public double CuantiaAyuda { set; get; }
        public int FormaPago { set; get; }

        public Socio(string nombre, string apellidos, string correo, string titularCuenta, string numeroCuenta, double cuantiaAyuda, int formaPago)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Correo = correo;
            TitularCuenta = titularCuenta;
            NumeroCuenta = numeroCuenta;
            CuantiaAyuda = cuantiaAyuda;
            FormaPago = formaPago;
        }

        public void Actualizar(string nombre, string apellidos, string correo, string titularCuenta, string numeroCuenta, double cuantiaAyuda, int formaPago)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Correo = correo;
            TitularCuenta = titularCuenta;
            NumeroCuenta = numeroCuenta;
            CuantiaAyuda = cuantiaAyuda;
            FormaPago = formaPago;
        }
    }
}
