using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class Principal
    {
        public double ObtenerFuncion(double Limite)
        {
            double Euler = 2.71828182845;
            double resultadoo = ((System.Math.Pow(Limite,5)) * (System.Math.Pow(Euler, Limite)) - 10);
            return resultadoo;
        }

        public Resultado ObtenerRaizBiseccion()
        {
            Resultado ResultadoRetorno = new Resultado();

            

            return ResultadoRetorno;
        }

        public Resultado ObtenerRaizReglaFalsa()
        {
            Resultado ResultadoRetorno = new Resultado();



            return ResultadoRetorno;
        }

        public Resultado ObtenerRaizNewtonRaphson()
        {
            Resultado ResultadoRetorno = new Resultado();



            return ResultadoRetorno;
        }

        public Resultado ObtenerRaizSecante()
        {
            Resultado ResultadoRetorno = new Resultado();

            

            return ResultadoRetorno;
        }
    }
}