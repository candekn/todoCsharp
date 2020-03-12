using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Está seguro que desea salir?", "Salir de la Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string txtDia = "";
            txtDia = txtNumDia.Text;
            int dianum=0;
            if (string.IsNullOrEmpty(txtDia)||string.IsNullOrWhiteSpace(txtDia))
            {
                MessageBox.Show("Debe ingresar algo.");
            }
            if (int.TryParse(txtDia, out dianum))
            {
                    switch (dianum)
                    {
                        case 1: txtDiaPalabra.Text = "Lunes";
                            break;
                        case 2: txtDiaPalabra.Text = "Martes";
                            break;
                        case 3: txtDiaPalabra.Text = "Miercoles";
                            break;
                        case 4: txtDiaPalabra.Text = "Jueves";
                            break;
                        case 5: txtDiaPalabra.Text = "Viernes";
                            break;
                        case 6: txtDiaPalabra.Text = "Sabado";
                            break;
                        case 7: txtDiaPalabra.Text = "Domingo";
                            break;
                        default: MessageBox.Show("El numero debe ser de 1 a 7");
                        break;
                    }

            }
            else
            {
                MessageBox.Show("Solo puede ingresar numeros");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDiaPalabra.Clear();
            txtNumDia.Clear();
        }
    }
}
