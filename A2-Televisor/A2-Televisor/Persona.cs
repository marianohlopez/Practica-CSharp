using System;
using System.Collections.Generic;
using System.Text;

namespace A2_Televisor
{
    internal class Persona
    {
        private string nombre;
        private Domicilio domicilio;

        public Persona(string nombre, Domicilio domicilio ) 
        {

        }

        public string Nombre { get => nombre; set => nombre = value; }
        internal Domicilio Domicilio { get => domicilio; set => domicilio = value; }
    }
}
