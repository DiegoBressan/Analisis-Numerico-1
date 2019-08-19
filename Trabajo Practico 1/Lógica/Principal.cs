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
            // Calcula el f(limite) pedido
            double Euler = 2.71828182845;
            double resultadoo = ((System.Math.Pow(Limite,5)) * (System.Math.Pow(Euler, Limite)) - 10);
            return resultadoo;
        }

        public Resultado ObtenerRaizBiseccion(Datos dato, MetodoCerrado metodo)
        {
            Resultado ResultadoRetorno = new Resultado();

            int Cont = 0;

            do
            {



            } while (Cont < dato.Iteraciones && dato.Tolerancia < ResultadoRetorno.ErrorRelativo && ResultadoRetorno.Raiz != 0);

            return ResultadoRetorno;
        }

        public Resultado ObtenerRaizReglaFalsa(Datos dato, MetodoCerrado metodo)
        {
            Resultado ResultadoRetorno = new Resultado();

            int Cont = 0;

            do
            {



            } while (Cont < dato.Iteraciones && dato.Tolerancia < ResultadoRetorno.ErrorRelativo && ResultadoRetorno.Raiz != 0);

            return ResultadoRetorno;
        }

        public Resultado ObtenerRaizNewtonRaphson(Datos dato, MetodoAbierto metodo)
        {
            Resultado ResultadoRetorno = new Resultado();

            int Cont = 0;

            do
            {



            } while (Cont < dato.Iteraciones && dato.Tolerancia < ResultadoRetorno.ErrorRelativo && ResultadoRetorno.Raiz != 0);

            return ResultadoRetorno;
        }

        public Resultado ObtenerRaizSecante(Datos dato, MetodoAbierto metodo)
        {
            Resultado ResultadoRetorno = new Resultado();

            int Cont = 0;

            do
            {



            } while (Cont < dato.Iteraciones && dato.Tolerancia < ResultadoRetorno.ErrorRelativo && ResultadoRetorno.Raiz != 0);

            return ResultadoRetorno;
        }
    }
}