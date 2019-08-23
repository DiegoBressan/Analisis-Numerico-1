using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class Datos
    {
        public double Funcion { get; set; } //Preguntar que es
        public int Iteraciones { get; set; }
        public double Tolerancia { get; set; }

        public Datos(double funcion, int iter, double tole)
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