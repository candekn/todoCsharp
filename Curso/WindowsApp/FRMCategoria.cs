using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibDatos.Dal;
using LibDatos.Entidades;
namespace WindowsApp
{
    public partial class FRMCategoria : Form
    {
        public FRMCategoria()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable tbl = AdminCategoria.TraerTodos();
            dataGridCategoria.DataSource = tbl;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();
            objCategoria.Nombre = "Consultoria";
            int filasAfectadas = AdminCategoria.Insertar(objCategoria);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Filas afectadas: " + filasAfectadas);
            }
            else
            {
                MessageBox.Show("No se pudo insertar");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();
            objCategoria.Nombre = "Consultoria Actualizada";
            objCategoria.Id = 4;
            int filasAfectadas = AdminCategoria.Actualizar(objCategoria);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Filas afectadas: " + filasAfectadas);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int filasAfectadas = AdminCategoria.Eliminar(4);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Se elimino: " + filasAfectadas);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }
    }
}
