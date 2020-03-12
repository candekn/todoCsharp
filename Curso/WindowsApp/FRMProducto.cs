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
    public partial class FRMProducto : Form
    {
        public FRMProducto()
        {
            InitializeComponent();
        }

        private void FRMProducto_Load(object sender, EventArgs e)
        {
            DataTable tblProducto = AdminProducto.TraerTodo();
            dataGridProducto.DataSource = tblProducto;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Producto objProducto = new Producto();
            objProducto.Nombre = "Procesador";
            objProducto.Proveedor = "AMD";
            objProducto.CategoriaID = 1;
            int filasAfectadas = AdminProducto.Insertar(objProducto);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Objeto insertado exitosamente");
            }
            else
            {
                MessageBox.Show("No se pudo insertar");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.Nombre = "Procesador 2.0";
            p.Proveedor = "AMD FX";
            p.CategoriaID = 1;
            p.Id = 4;
            int filasAfectadas = AdminProducto.Actualizar(p);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Producto actualizado exitosamente");
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int filasAfectadas = AdminProducto.Eliminar(4);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Producto eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Hubo un problema al eliminar el producto");
            }
        }

        private void btnFiltroProveedor_Click(object sender, EventArgs e)
        {
            DataTable tblProducto = AdminProducto.TraerTodo("Microsoft");
            dataGridProducto.DataSource = tblProducto;
        }

        private void btnFiltrarPorCategoria_Click(object sender, EventArgs e)
        {
            DataTable tblProducto = AdminProducto.TraerTodo(1);
            dataGridProducto.DataSource = tblProducto;
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            DataTable tblProducto = AdminProducto.TraerTodo();
            dataGridProducto.DataSource = tblProducto;
        }
    }
}
