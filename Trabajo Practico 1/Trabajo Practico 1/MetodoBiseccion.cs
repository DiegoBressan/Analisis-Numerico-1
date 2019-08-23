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
    public partial class MetodoBiseccion : Form
    {
        private MetodoBiseccion metodoBiseccion;

        public MetodoBiseccion(MetodoCerrado metodo, Datos datos)
        {
            InitializeComponent();
            CompletarDatosMetodo(metodo, datos);
        }

        private void CompletarDatosMetodo(MetodoCerrado metodo, Datos datos)
        {
            this.textBox1.Text = Convert.ToString(datos.Funcion);
            this.textBox2.Text = Convert.ToString(datos.Iteraciones);
            this.textBox3.Text = Convert.ToString(datos.Iteraciones);
            this.textBox4.Text = Convert.ToString(metodo.LimiteIzquierdo);
            this.textBox5.Text = Convert.ToString(metodo.LimiteDerecho);
        }

    }
}
