using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Actividad
    {
        private string nombre;
        private int cupos;

        public Actividad(string nombre, int cupos)
        {
            this.nombre = nombre;
            this.cupos = cupos;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cupos { get => cupos; set => cupos = value; }
    }
}
