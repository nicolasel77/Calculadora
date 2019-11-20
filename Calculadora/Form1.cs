using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void cmd7_Click(object sender, EventArgs e)
        {

            Button botonaso = sender as Button;

            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = botonaso.Text;
            }
            else
            {
                lblDisplay.Text += botonaso.Text;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Botón coma
                        
            if (lblDisplay.Text.IndexOf(",") == -1) 
            {
                lblDisplay.Text += ",";
            }

            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Botón -/+
            int buscar = lblDisplay.Text.IndexOf("-");

            if (buscar == -1)
            {
                lblDisplay.Text = "-" + lblDisplay.Text;
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text.Substring(1);
            }
        }

        private void cmdIgual_Click(object sender, EventArgs e)
        {
            //Boton =
            lblValor2.Text = lblDisplay.Text;

            float valor1;
            float valor2;

            valor1 =  float.Parse(lblValor1.Text);
            valor2 = float.Parse(lblDisplay.Text);

            if (cmdFuncion.Text == "+")
            {
                lblDisplay.Text = (valor1 + valor2).ToString();
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Boton +
            lblValor1.Text = lblDisplay.Text;
            lblDisplay.Text = "0";
            cmdFuncion.Text = "+";  
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Boton -
            lblValor1.Text = lblDisplay.Text;
            lblDisplay.Text = "0";
            cmdFuncion.Text = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Boton *
            lblValor1.Text = lblDisplay.Text;
            lblDisplay.Text = "0";
            cmdFuncion.Text = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Boton /
            lblValor1.Text = lblDisplay.Text;
            lblDisplay.Text = "0";
            cmdFuncion.Text = "/";
        }
    }
}
