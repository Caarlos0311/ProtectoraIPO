using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectoraIPO.Clases
{
    public class Perro
    {
        public string Nombre { set; get; }
        public int Sexo { set; get; }
        public string Raza { set; get; }
        public double Peso { set; get; }
        public int Edad { set; get; }
        public DateTime FechaEntrada { set; get; }
        public string Chip { set; get; }
        public bool Ppp { set; get; }
        public bool Vacunado { set; get; }
        public bool Esterilizado { set; get; }
        public string Enfermedades { set; get; }
        public Uri Foto { set; get; }
        public string Descripcion { set; get; }
        public bool Sociable { set; get; }
        public int Estado { set; get; }
        public Padrino Padr { set; get; }

        public Perro(string nombre, int sexo, string raza, double peso, int edad, DateTime fechaEntrada,
            string chip, bool ppp, bool vacunado, bool esterilizado, string enfermedades, Uri foto, string descripcion, bool sociable, int estado, Padrino padr)
        {
            Nombre = nombre;
            Sexo = sexo;
            Raza = raza;
            Peso = peso;
            Edad = edad;
            FechaEntrada = fechaEntrada;
            Chip = chip;
            Ppp = ppp;
            Vacunado = vacunado;
            Esterilizado = esterilizado;
            Enfermedades = enfermedades;
            Foto = foto;
            Descripcion = descripcion;
            Sociable = sociable;
            Estado = estado;
            Padr = padr;
        }
        public void Actualizar(string nombre, int sexo, string raza, double peso, int edad, DateTime fechaEntrada,
            string chip, bool ppp, bool vacunado, bool esterilizado, string enfermedades, Uri foto, string descripcion, bool sociable, int estado, Padrino padr)
        {
            Nombre = nombre;
            Sexo = sexo;
            Raza = raza;
            Peso = peso;
            Edad = edad;
            FechaEntrada = fechaEntrada;
            Chip = chip;
            Ppp = ppp;
            Vacunado = vacunado;
            Esterilizado = esterilizado;
            Enfermedades = enfermedades;
            Foto = foto;
            Descripcion = descripcion;
            Sociable = sociable;
            Estado = estado;
            Padr = padr;
        }
    }
}
