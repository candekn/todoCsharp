using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chAplicarDescuento_CheckedChanged(object sender, EventArgs e)
        {
            txtDescuento.ReadOnly = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            double sueldo = 0.0, ad = 0.0, desc = 0.0;
            double sueldoCobrar;
            if (chAplicarDescuento.Checked == true&& double.TryParse(txtSueldo.Text, out sueldo))
            {
                if (double.TryParse(txtSueldo.Text, out sueldo)
                && double.TryParse(txtDescuento.Text, out desc)
                && double.TryParse(txtAdicional.Text, out ad))
                {
                    sueldoCobrar = sueldo - desc + ad;
                }
                else
                {
                    MessageBox.Show("Ingrese datos validos!!");
                }
            }
            else
            {
                sueldo = sueldo + ad;
            }
            
        }
    }
}
