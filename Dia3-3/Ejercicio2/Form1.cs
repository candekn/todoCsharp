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

        private void button2_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn2.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string txt1 = "", txt2 = "";
            double n1=0, n2=0, suma=0, resta=0, 
                division=0, multiplicacion=0, raiz=0, potencia=0;
            txt1 = txtn1.Text;
            txt2 = txtn2.Text;
            if (txt1 == "" || txt2 == "")
            {
                MessageBox.Show("Ingrese un numero!");
            }
            else
            {
                n1 = double.Parse(txt1);
                n2 = double.Parse(txt2);
                suma = n1 + n2;
                resta = n1 / n2;
                multiplicacion = n1 * n2;
                potencia = Math.Pow(n1, n2);
                raiz = Math.Pow(n1, (1 / n2));
                for(int i=0; i<n2; i++)
                {
                    
                }
                if (n2 == 0)
                {
                    MessageBox.Show("No se puede dividir por cero!");
                    txtn2.Clear();
                }
                else
                {
                    division = n1 / n2;
                }
            }
            lblSuma.Text = "La suma es: " + suma;
            lblResta.Text = "La resta es: " + resta;
            lblDivision.Text = "La division es: " + division;
            lblMultiplicacion.Text = "La multiplicacion es: " + multiplicacion;
            lblPotencia.Text = "La potencia es: " + potencia;
            lblRaiz.Text = "La raiz es: " + raiz;

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
    }
}
