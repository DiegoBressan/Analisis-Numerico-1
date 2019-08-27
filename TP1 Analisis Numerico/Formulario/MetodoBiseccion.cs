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
    public partial class MetodoBiseccion : Form 
    {
        public MetodoBiseccion(MetodoCerrado metodo, Datos datos)
        {
            InitializeComponent();
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Resultado NuevoResultado = new Resultado();

            if (this.textBox1.Text != "" && this.textBox2.Text != "" && this.textBox3.Text != "" && this.textBox4.Text != "" && this.textBox5.Text != "") 
            {
                Datos datos = new Datos();
                MetodoCerrado metodo = new MetodoCerrado();

                datos.Funcion = this.textBox1.Text;
                datos.Iteraciones = Convert.ToInt32(this.textBox2.Text);
                datos.Tolerancia = Convert.ToDouble(this.textBox3.Text);
                metodo.LimiteIzquierdo = Convert.ToDouble(this.textBox4.Text);
                metodo.LimiteDerecho = Convert.ToDouble(this.textBox5.Text);

                FormularioPrincipal formularioprincipal = this.Owner as FormularioPrincipal;
                if (formularioprincipal != null)
                {
                    NuevoResultado = formularioprincipal.ObenerRaizBiseccion(datos, metodo);
                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    label10.Text = Convert.ToString(NuevoResultado.Iteraciones);
                    label11.Text = Convert.ToString(NuevoResultado.ErrorRelativo);
                    label12.Text = Convert.ToString(NuevoResultado.Raiz);
                }               
            }
            else
            {
                MessageBox.Show("Complete Todos los Campos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
