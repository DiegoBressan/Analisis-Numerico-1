﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Datos
    {
        public string Funcion { get; set; } //Preguntar que es
        public int Iteraciones { get; set; }
        public double Tolerancia { get; set; }

        public Datos(string funcion, int iter, double tole)
        {
            this.Funcion = funcion;
            this.Iteraciones = iter;
            this.Tolerancia = tole;
        }

        public Datos()
        {

        }
    }
}