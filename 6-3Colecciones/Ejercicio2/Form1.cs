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
        private List<Persona> listaP = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad = 0;
            if((int.TryParse(txtEdad.Text, out edad))
                &&!(string.IsNullOrEmpty(txtNombre.Text))
                &&!(string.IsNullOrEmpty(txtApellido.Text)))
            {
                Persona p = new Persona(txtNombre.Text, txtApellido.Text, edad);
                listaP.Add(p);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaP;
                txtNombre.Clear();
                txtApellido.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese datos validos!");
               
            }
            txtEdad.Clear();

        }

        
    }
}
