﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MetodoCerrado
    {
        public double LimiteIzquierdo { get; set; }
        public double LimiteDerecho { get; set; }

        public MetodoCerrado(double li, double ld)
        {
            this.LimiteIzquierdo = li;
            this.LimiteDerecho = ld;
        }

        public MetodoCerrado()
        {

        }
    }
}