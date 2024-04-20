using System;
using System.Collections.Generic;
using System.Text;

namespace A2_Televisor
{
    internal class Domicilio
    {
        private string calle;
        private int numero;
        private string barrio;

        public Domicilio(string calle, int numero, string barrio)
        {
            this.calle = calle;
            this.numero = numero;
            this.barrio = barrio;
        }
    }
}
