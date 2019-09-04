using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Resultado
    {
        public int Iteraciones { get; set; }
        public double Raiz { get; set; }
        public double ErrorRelativo { get; set; }
        public bool MayorACero { get; set; }
        public decimal VariableRetorno { get; set; }

        public Resultado(int iter, double raiz, double error)
        {
            this.Iteraciones = iter;
            this.Raiz = raiz;
            this.ErrorRelativo = error;
        }

        public Resultado()
        {
        }
    }
}