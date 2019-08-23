using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lógica;

namespace Trabajo_Practico_1
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
        public Resultado ObtenerRaizBiseccion(Datos dato, MetodoCerrado metodo)
        {
            return Principal.ObtenerRaizBiseccion(dato, metodo);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MetodoBiseccion nuevo = new MetodoBiseccion(new MetodoCerrado(), new Datos());
            nuevo.Owner = this;
            nuevo.ShowDialog();
        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {

        }


    }
}
