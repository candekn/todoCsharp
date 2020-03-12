using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double numero1=0, numero2=0; 
            string num1 = txtNum1.Text;
            string num2 = txtNum2.Text;
            if (string.IsNullOrEmpty(num1) || string.IsNullOrEmpty(num2))
            {
                MessageBox.Show("Ingrese datos en los dos operandos");
            }
            else
            {
                if ((double.TryParse(num1, out numero1))
               && (double.TryParse(num2, out numero2)))
                {
                    if (rdbSuma.Checked)
                    {
                        txtResultado.Text = (numero1 + numero2).ToString();
                    }
                    else if (rbdResta.Checked)
                    {
                        txtResultado.Text = (numero1 - numero2).ToString();
                    }
                    else if (rbdMultiplicacion.Checked)
                    {
                        txtResultado.Text = (numero1 * numero2).ToString();
                    }
                    else if (rbdDivision.Checked)
                    {
                        if (numero2 == 0)
                        {
                            MessageBox.Show("No se puede dividir por cero");
                            txtNum2.Clear();
                        }
                        else
                        {
                            txtResultado.Text = (numero1 / numero2).ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una opcion valida");
                    }

                }
            }
           
            }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }
    }


}
 

