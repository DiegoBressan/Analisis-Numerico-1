using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Formulario
{
    public partial class PantallaInicio : Form, FormularioPrincipal
    {
        public Principal Principal { get; set; }

        public PantallaInicio()
        {
            Principal = new Principal();

            InitializeComponent();
        }
        //BISECCION
        public Resultado ObenerRaizBiseccion(Datos dato, MetodoCerrado metodo)
        {
            return Principal.ObtenerRaizBiseccion(dato, metodo);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MetodoBiseccion nuevo = new MetodoBiseccion(new MetodoCerrado(), new Datos());
            nuevo.Owner = this;
            nuevo.ShowDialog();
        }
        //REGLA FALSA
        public Resultado ObtenerRaizReglaFalsa(Datos dato, MetodoCerrado metodo)
        {
            return Principal.ObtenerRaizReglaFalsa(dato, metodo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MetodoReglaFalsa nuevo = new MetodoReglaFalsa(new MetodoCerrado(), new Datos());
            nuevo.Owner = this;
            nuevo.ShowDialog();
        }
        //NEWTON-RAPHSON
        public Resultado ObtenerRaizNewtonRaphson(Datos dato, MetodoAbierto metodo)
        {
            return Principal.ObtenerRaizNewtonRaphson(dato, metodo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MetodoNewton_Raphsow nuevo = new MetodoNewton_Raphsow(new MetodoAbierto(), new Datos());
            nuevo.Owner = this;
            nuevo.ShowDialog();
        }
        //SECANTE
        public Resultado ObtenerRaizSecante(Datos dato, MetodoAbierto metodo)
        {
            return Principal.ObtenerRaizSecante(dato, metodo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MetodoSecante nuevo = new MetodoSecante(new MetodoAbierto(), new Datos());
            nuevo.Owner = this;
            nuevo.ShowDialog();
        }
    }
}
