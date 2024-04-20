using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Socio
    {
        private string nombre;
        private string apellido;

        public Socio(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public string Nombre { get => Nombre; set => Nombre = value; }
        public string Apellido { get => Apellido; set => Apellido = value; }
    }
}
