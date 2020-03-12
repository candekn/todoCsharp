using CodeFirstNewDatabaseSample.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstNewDatabaseSample
{
    public partial class FRMBlog : Form
    {
        public FRMBlog()
        {
            InitializeComponent();
        }

        private void FRMBlog_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreBlog.Text;
            BlogginContext bc = new BlogginContext();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese un nombre para el Blog");
            }
            else
            {
                
                Blog miBlog = new Blog() { Name = nombre };
                bc.Blogs.Add(miBlog);
                bc.SaveChanges();
            }

            //LINQ

            var query = (from b in bc.Blogs
                        
                        select b).ToList<Blog>();
            dgvBlogs.DataSource = query;

        }
    }
}
