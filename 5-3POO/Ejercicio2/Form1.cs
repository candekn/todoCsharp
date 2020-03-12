using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1=0, n2=0;
            if((double.TryParse(txtNumero1.Text,out n1))
                &&double.TryParse(txtNumero2.Text,out n2))
            {
                Suma sum = new Suma(n1, n2);
                Resta rest = new Resta(n1, n2);
                sum.Operar(); rest.Operar();
                txtSuma.Text = sum.Imprimir();
                txtResta.Text = rest.Imprimir();
            }
            else
            {
                MessageBox.Show("Ingrese datos válidos!");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtSuma.Clear();
            txtResta.Clear();
        }
    }
}
