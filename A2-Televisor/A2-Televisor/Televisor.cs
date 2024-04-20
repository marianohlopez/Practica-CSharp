using System;
using System.Collections.Generic;
using System.Text;

namespace A2_Televisor
{
    internal class Televisor
    {
        private string marca;
        private string modelo;
        private int cantPulg;
        private bool estado;
        private int canal;

        public Televisor(string marca, string modelo, int cantPulg)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.CantPulg = cantPulg;
            estado = false;
            canal = 1;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int CantPulg { get => cantPulg; set => cantPulg = value; }
        public bool Estado { get => estado; set => estado = value; }
        public int Canal { get => canal; set => canal = value; }
    }
}
