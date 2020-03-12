using LibDatos.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFacturacion
{
    public partial class FRMCliente : Form
    {
        public FRMCliente()
        {
            InitializeComponent();
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            DataTable tblCliente = AdminCliente.TraerTodos();
            dgvCliente.DataSource = tblCliente;

        }

        private void FRMCliente_Load(object sender, EventArgs e)
        {
            DataTable tblCliente = AdminCliente.TraerTodos();
            dgvCliente.DataSource = tblCliente;
            cbCiudades.DataSource = AdminCliente.TraerCiudades().DefaultView;
            cbCiudades.DisplayMember = "Ciudad";

        }

        private void btnFiltroCiudad_Click(object sender, EventArgs e)
        {
          
            string ciudad = cbCiudades.Text;
            if (string.IsNullOrEmpty(ciudad))
            {
                MessageBox.Show("Seleccione una ciudad");
            }
            else
            {
                
                DataTable tblClienteCiudad = AdminCliente.TraerTodos(ciudad);
                if (tblClienteCiudad.Rows.Count > 0)
                {
                    dgvCliente.DataSource = tblClienteCiudad;
                }
                else
                {
                    MessageBox.Show("No existen Clientes para esa Ciudad");
                }
                
            }
        }
    }
}
