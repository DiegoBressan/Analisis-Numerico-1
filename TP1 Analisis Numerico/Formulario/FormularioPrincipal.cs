using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Formulario
{
    interface FormularioPrincipal
    {
        //BISECCION
        Resultado ObenerRaizBiseccion(Datos dato, MetodoCerrado metodo);
        //REGLA FALSA
        Resultado ObtenerRaizReglaFalsa(Datos dato, MetodoCerrado metodo);
        //NEWTON-RAPHSON
        Resultado ObtenerRaizNewtonRaphson(Datos dato, MetodoAbierto metodo);
        //SECANTE
        Resultado ObtenerRaizSecante(Datos dato, MetodoAbierto metodo);
    }
}
