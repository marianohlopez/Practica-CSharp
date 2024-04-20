using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEjercicio
{
    internal class Postulante
    {
        private string nombre;
        private string apellido;
        private string tipo;
        private string documento;

        public Postulante(string nombre, string apellido, string tipo, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipo = tipo;
            this.documento = documento;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Documento { get => documento; set => documento = value; }
    }
}
