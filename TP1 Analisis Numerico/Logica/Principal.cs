using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Principal
    {
        public double ObtenerFuncion(double Limite)
        {
            // Calcula el f(limite) pedido
            double resultadoo = new double();

            // Ejercicio 1
            //double Euler = 2.71828182845;
            //resultadoo = ((Math.Pow(Limite, 5)) * (Math.Pow(Euler, Limite)) - 10);

            // Ejercicio 2
            // resultadoo = ((Math.Log(Limite)) + (1 / Limite) - 3);

            // Ejercicio 3
            /*double AuxArriba = (12.5) * (Limite + 2);
            double AuxAbajo = (Math.Pow(Limite, 2)) + (4 * Limite) + 5;
            resultadoo = (AuxArriba / AuxAbajo) + 2;*/

            // Ejercicio 4
            double Aux = (Math.Pow(Limite, 2)) - 4;
            if (Aux < 0)
            {Aux = Aux * -1;}
            resultadoo = Aux + (2 * Limite);

            // Ejercicio 5
            /*double Gfuncion = 5 - (Math.Sqrt(Limite));
            double Ffuncion = (Math.Pow(Limite, 2)) - (3 * Limite) + (Math.Log(1 + Limite));
            resultadoo = Ffuncion - Gfuncion;*/

            return resultadoo;
        }

        public Resultado ObtenerRaizBiseccion(Datos dato, MetodoCerrado metodo)
        {
            Resultado ResultadoRetorno = new Resultado();
            ResultadoRetorno.MayorACero = false;

            int ban = 0;

            while (ban == 0)
            {
                if ((ObtenerFuncion(metodo.LimiteIzquierdo) * ObtenerFuncion(metodo.LimiteDerecho)) < 0)
                {
                    ban = 1;
                }
                else
                {
                    if ((ObtenerFuncion(metodo.LimiteIzquierdo) * ObtenerFuncion(metodo.LimiteDerecho)) == 0)
                    {
                        if (ObtenerFuncion(metodo.LimiteIzquierdo) == 0)
                        {
                            ResultadoRetorno.Raiz = metodo.LimiteIzquierdo;
                            ResultadoRetorno.Iteraciones = 0;
                        }
                        else
                        {
                            ResultadoRetorno.Raiz = metodo.LimiteDerecho;
                            ResultadoRetorno.Iteraciones = 0;
                        }
                        ban = 2;
                    }
                    else
                    {
                        //Aca se pediria los limites de nuevo
                        ResultadoRetorno.MayorACero = true;
                        ban = 3;
                    }
                }
            }

            if (ban == 1)
            {
                double Ant = 0;
                int Cont = 0;
                double Xr = 0;
                bool band = false;

                do
                { 
                    Xr = (metodo.LimiteIzquierdo + metodo.LimiteDerecho) / 2;
                    Cont += 1;
                    ResultadoRetorno.ErrorRelativo = 0;
                    ResultadoRetorno.ErrorRelativo = (Xr - Ant) / Xr;
                    if (ResultadoRetorno.ErrorRelativo< 0)
                    {
                        ResultadoRetorno.ErrorRelativo = ResultadoRetorno.ErrorRelativo* -1;
                    }

                    if (ObtenerFuncion(Xr) == 0)
                    {
                        ResultadoRetorno.Raiz = Xr;
                        band = true;
                    }
                    else
                    {
                        if ((ObtenerFuncion(Xr) * ObtenerFuncion(metodo.LimiteIzquierdo)) < 0)
                        {
                            metodo.LimiteDerecho = Xr;
                        }
                        else
                        {
                            metodo.LimiteIzquierdo = Xr;
                        }
                        Ant = Xr;
                    }                   

                } while (Cont<dato.Iteraciones && dato.Tolerancia<ResultadoRetorno.ErrorRelativo && band == false);

                if (dato.Tolerancia > ResultadoRetorno.ErrorRelativo || Cont >= dato.Iteraciones)
                {
                    ResultadoRetorno.Raiz = Xr;
                }
                ResultadoRetorno.Iteraciones = Cont;
            }
            ResultadoRetorno.ErrorRelativo = Math.Round(ResultadoRetorno.ErrorRelativo, 6);

            ResultadoRetorno.Raiz = Math.Round(ResultadoRetorno.Raiz, 6);

            return ResultadoRetorno;
        }

        public Resultado ObtenerRaizReglaFalsa(Datos dato, MetodoCerrado metodo)
        {
            Resultado ResultadoRetorno = new Resultado();
            ResultadoRetorno.MayorACero = false;

            int ban = 0;

            while (ban == 0)
            {
                if ((ObtenerFuncion(metodo.LimiteIzquierdo) * ObtenerFuncion(metodo.LimiteDerecho)) < 0)
                {
                    ban = 1;
                }
                else
                {
                    if ((ObtenerFuncion(metodo.LimiteIzquierdo) * ObtenerFuncion(metodo.LimiteDerecho)) == 0)
                    {
                        if (ObtenerFuncion(metodo.LimiteIzquierdo) == 0)
                        {
                            ResultadoRetorno.Raiz = metodo.LimiteIzquierdo;
                            ResultadoRetorno.Iteraciones = 0;
                        }
                        else
                        {
                            ResultadoRetorno.Raiz = metodo.LimiteDerecho;
                            ResultadoRetorno.Iteraciones = 0;
                        }
                        ban = 2;
                    }
                    else
                    {
                        //Aca se pediria los limites de nuevo
                        ResultadoRetorno.MayorACero = true;
                        ban = 3;
                    }
                }
            }

            if (ban == 1)
            {
                double Ant = 0;
                int Cont = 0;
                double Xr = 0;
                bool band = false;

                do
                {
                    Cont += 1;
                    Xr = ((ObtenerFuncion(metodo.LimiteIzquierdo) * metodo.LimiteDerecho) - (ObtenerFuncion(metodo.LimiteDerecho) * metodo.LimiteIzquierdo)) / (ObtenerFuncion(metodo.LimiteIzquierdo) - ObtenerFuncion(metodo.LimiteDerecho));
                    ResultadoRetorno.ErrorRelativo = (Xr - Ant) / Xr;

                    if (ResultadoRetorno.ErrorRelativo < 0)
                    {
                        ResultadoRetorno.ErrorRelativo = ResultadoRetorno.ErrorRelativo * -1;
                    }

                    if (ObtenerFuncion(Xr) == 0)
                    {
                        ResultadoRetorno.Raiz = Xr;
                        band = true;
                    }
                    else
                    {
                        if ((ObtenerFuncion(Xr) * ObtenerFuncion(metodo.LimiteIzquierdo)) < 0)
                        {
                            metodo.LimiteDerecho = Xr;
                        }
                        else
                        {
                            metodo.LimiteIzquierdo = Xr;
                        }
                        Ant = Xr;
                    }

                } while (Cont < dato.Iteraciones && dato.Tolerancia < ResultadoRetorno.ErrorRelativo && band == false);

                if (dato.Tolerancia > ResultadoRetorno.ErrorRelativo || Cont >= dato.Iteraciones)
                {
                    ResultadoRetorno.Raiz = Xr;
                }
                ResultadoRetorno.Iteraciones = Cont;
            }
            ResultadoRetorno.ErrorRelativo = Math.Round(ResultadoRetorno.ErrorRelativo, 6);

            ResultadoRetorno.Raiz = Math.Round(ResultadoRetorno.Raiz, 6);

            return ResultadoRetorno;
        }

        public Resultado ObtenerRaizNewtonRaphson(Datos dato, MetodoAbierto metodo)
        {
            Resultado ResultadoRetorno = new Resultado();
            ResultadoRetorno.MayorACero = false;

            int ban = 0;

            if (ObtenerFuncion(metodo.Limite) == 0)
            {
                ResultadoRetorno.Raiz = metodo.Limite;
            }
            else
            {
                if (ObtenerFuncion(metodo.Limite) < 0)
                {
                    ban = 1;
                }
                else
                {
                    ResultadoRetorno.MayorACero = false;
                    ban = 2;
                }
            }

            if (ban == 1)
            {
                bool band = false;
                double Ant = 0;
                int Cont = 0;
                double Deriv = 0;
                double Xr = 0;

                do
                {
                    Cont += 1;
                    Deriv = (ObtenerFuncion(metodo.Limite + 0.0001) - (ObtenerFuncion(metodo.Limite) / (0.0001)));
                    Xr = (metodo.Limite - ObtenerFuncion(metodo.Limite)) / Deriv;
                    ResultadoRetorno.ErrorRelativo = (Xr - Ant) / Xr;

                    if (ResultadoRetorno.ErrorRelativo < 0)
                    {
                        ResultadoRetorno.ErrorRelativo = ResultadoRetorno.ErrorRelativo * -1;
                    }

                    if (ObtenerFuncion(Xr) == 0)
                    {
                        ResultadoRetorno.Raiz = Xr;
                        ResultadoRetorno.Iteraciones = Cont;
                        band = true;
                    }
                    else
                    {
                        metodo.Limite = Xr;
                        Ant = Xr;
                    }

                } while (Cont < dato.Iteraciones && dato.Tolerancia < ResultadoRetorno.ErrorRelativo && band == false);

                if (dato.Tolerancia > ResultadoRetorno.ErrorRelativo || Cont >= dato.Iteraciones)
                {
                    ResultadoRetorno.Raiz = Xr;
                }
                ResultadoRetorno.Iteraciones = Cont;
            }
            ResultadoRetorno.ErrorRelativo = Math.Round(ResultadoRetorno.ErrorRelativo, 6);

            ResultadoRetorno.Raiz = Math.Round(ResultadoRetorno.Raiz, 6);

            return ResultadoRetorno;
        }

        public Resultado ObtenerRaizSecante(Datos dato, MetodoAbierto metodo)
        {
            Resultado ResultadoRetorno = new Resultado();
            ResultadoRetorno.MayorACero = false;

            int ban = 0;

            if (ObtenerFuncion(metodo.Limite) == 0)
            {
                ResultadoRetorno.Raiz = metodo.Limite;
            }
            else
            {
                if (ObtenerFuncion(metodo.Limite) < 0)
                {
                    ban = 1;
                }
                else
                {
                    ResultadoRetorno.MayorACero = true;
                    ban = 2;
                }
            }

            if (ban == 1)
            {
                bool band = false;
                double Ant = 0;
                int Cont = 0;
                double Deriv = 0;
                double Xr = 0;

                do
                {
                    Cont += 1;
                    Deriv = ((ObtenerFuncion(metodo.Limite + 1) * metodo.Limite) - ((ObtenerFuncion(metodo.Limite) * (metodo.Limite + 1))));
                    Xr = Deriv / ((ObtenerFuncion(metodo.Limite + 1) - ObtenerFuncion(metodo.Limite)));
                    ResultadoRetorno.ErrorRelativo = (Xr - Ant) / Xr;

                    if (ResultadoRetorno.ErrorRelativo < 0)
                    {
                        ResultadoRetorno.ErrorRelativo = ResultadoRetorno.ErrorRelativo * -1;
                    }

                    if (ObtenerFuncion(Xr) == 0)
                    {
                        ResultadoRetorno.Raiz = Xr;
                        ResultadoRetorno.Iteraciones = Cont;
                        band = true;
                    }
                    else
                    {
                        metodo.Limite = Xr;
                        Ant = Xr;
                    }                   

                } while (Cont < dato.Iteraciones && dato.Tolerancia < ResultadoRetorno.ErrorRelativo && band == false);

                if (dato.Tolerancia > ResultadoRetorno.ErrorRelativo || Cont >= dato.Iteraciones)
                {
                    ResultadoRetorno.Raiz = Xr;
                }
                ResultadoRetorno.Iteraciones = Cont;
            }
            ResultadoRetorno.ErrorRelativo = Math.Round(ResultadoRetorno.ErrorRelativo, 6);

            ResultadoRetorno.Raiz = Math.Round(ResultadoRetorno.Raiz, 6);

            return ResultadoRetorno;
        }
    }
}