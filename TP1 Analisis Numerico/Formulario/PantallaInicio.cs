using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Formulario
{
    public partial class PantallaInicio
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