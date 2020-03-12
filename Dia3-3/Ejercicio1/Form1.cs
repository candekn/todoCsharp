using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double seg = 0.0, min, horas;
            string segTxt = txtSegundo.Text;
            if (segTxt == "")
            {
                MessageBox.Show("Ingrese un numero!");
            }
            else
            {
                seg = double.Parse(segTxt);
                min = seg / 60;
                horas = min / 60;
                MessageBox.Show("La cantidad de minutos es: " + min + ". La cantidad de horas: " + horas);

            }
            }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSegundo.Clear();
        }
    }
}
