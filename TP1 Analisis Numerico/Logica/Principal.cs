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
            double Euler = 2.71828182845;
            double resultadoo = ((System.Math.Pow(Limite, 5)) * (System.Math.Pow(Euler, Limite)) - 10);
            return resultadoo;
        }

        public Resultado ObtenerRaizBiseccion(Datos dato, MetodoCerrado metodo)
        {
            Resultado ResultadoRetorno = new Resultado();

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
            }

            return ResultadoRetorno;
        }

        public Resultado ObtenerRaizReglaFalsa(Datos dato, MetodoCerrado metodo)
        {
            Resultado ResultadoRetorno = new Resultado();

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
            }

            return ResultadoRetorno;
        }

        public Resultado ObtenerRaizNewtonRaphson(Datos dato, MetodoAbierto metodo)
        {
            Resultado ResultadoRetorno = new Resultado();

            bool ban = false;

            if (ObtenerFuncion(metodo.Limite) == 0)
            {
                ResultadoRetorno.Raiz = metodo.Limite;
            }
            else
            {
                ban = true;
            }

            if (ban == true)
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
            }

            return ResultadoRetorno;
        }

        public Resultado ObtenerRaizSecante(Datos dato, MetodoAbierto metodo)
        {
            Resultado ResultadoRetorno = new Resultado();

            bool ban = false;

            if (ObtenerFuncion(metodo.Limite) == 0)
            {
                ResultadoRetorno.Raiz = metodo.Limite;
            }
            else
            {
                ban = true;
            }

            if (ban == true)
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
            }

            return ResultadoRetorno;
        }
    }
}