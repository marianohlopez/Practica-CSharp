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
        private int dni;
        private List<string> actividadesInscriptas;

        public Socio(string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.ActividadesInscriptas = new List<string>();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public List<string> ActividadesInscriptas { get => actividadesInscriptas; set => actividadesInscriptas = value; }
    }
}
