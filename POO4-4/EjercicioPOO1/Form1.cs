using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPOO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int legajo = 0;
            if(string.IsNullOrEmpty(txtNombre.Text)||
            (string.IsNullOrEmpty(txtNombre.Text))||
            (!(int.TryParse(txtLegajo.Text, out legajo)))){
                MessageBox.Show("Ingrese datos validos!");
            }
            else
            {
                Estudiante e1 = new Estudiante(legajo, txtNombre.Text, txtApellido.Text);
                lblImprimir.Text = e1.Imprimir();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtLegajo.Clear();
            lblImprimir.Text = " ";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Seguro que desea salir?", "No te vaias Chavito", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
