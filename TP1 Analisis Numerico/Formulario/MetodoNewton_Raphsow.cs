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
    public partial class MetodoNewton_Raphsow : Form
    {
        public MetodoNewton_Raphsow(MetodoAbierto metodoAbierto, Datos datos)
        {
            InitializeComponent();
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            CompletarDatosMetodo(metodoAbierto, datos);
        }
        private void CompletarDatosMetodo(MetodoAbierto metodo, Datos datos)
        {
            this.textBox1.Text = Convert.ToString(datos.Funcion);
            this.textBox2.Text = Convert.ToString(datos.Iteraciones);
            this.textBox3.Text = Convert.ToString(datos.Tolerancia);
            this.textBox4.Text = Convert.ToString(metodo.Limite);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resultado NuevoResultado = new Resultado();

            if (this.textBox1.Text != "" && this.textBox2.Text != "" && this.textBox3.Text != "" && this.textBox4.Text != "")
            {
                Datos datos = new Datos();
                MetodoAbierto metodo = new MetodoAbierto();

                datos.Funcion = this.textBox1.Text;
                datos.Iteraciones = Convert.ToInt32(this.textBox2.Text);
                datos.Tolerancia = Convert.ToDouble(this.textBox3.Text);
                metodo.Limite = Convert.ToDouble(this.textBox4.Text);               

                FormularioPrincipal formularioprincipal = this.Owner as FormularioPrincipal;
                if (formularioprincipal != null)
                {
                    NuevoResultado = formularioprincipal.ObtenerRaizNewtonRaphson(datos, metodo);
                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    label10.Text = Convert.ToString(NuevoResultado.Iteraciones);
                    label11.Text = Convert.ToString(NuevoResultado.VariableRetorno);
                    label12.Text = Convert.ToString(NuevoResultado.Raiz);
                    if (NuevoResultado.MayorACero == true)
                    {
                        MessageBox.Show("Ingrese un nuevo Limite, raiz no encontrada");
                    }
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
