namespace WindowsApp
{
    partial class FRMProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridProducto = new System.Windows.Forms.DataGridView();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFiltroProveedor = new System.Windows.Forms.Button();
            this.btnFiltrarPorCategoria = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProducto
            // 
            this.dataGridProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducto.Location = new System.Drawing.Point(12, 52);
            this.dataGridProducto.Name = "dataGridProducto";
            this.dataGridProducto.Size = new System.Drawing.Size(481, 200);
            this.dataGridProducto.TabIndex = 0;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(40, 295);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(146, 295);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(260, 295);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnFiltroProveedor
            // 
            this.btnFiltroProveedor.Location = new System.Drawing.Point(373, 271);
            this.btnFiltroProveedor.Name = "btnFiltroProveedor";
            this.btnFiltroProveedor.Size = new System.Drawing.Size(120, 23);
            this.btnFiltroProveedor.TabIndex = 5;
            this.btnFiltroProveedor.Text = "Filtrar por Proveedor";
            this.btnFiltroProveedor.UseVisualStyleBackColor = true;
            this.btnFiltroProveedor.Click += new System.EventHandler(this.btnFiltroProveedor_Click);
            // 
            // btnFiltrarPorCategoria
            // 
            this.btnFiltrarPorCategoria.Location = new System.Drawing.Point(373, 320);
            this.btnFiltrarPorCategoria.Name = "btnFiltrarPorCategoria";
            this.btnFiltrarPorCategoria.Size = new System.Drawing.Size(120, 23);
            this.btnFiltrarPorCategoria.TabIndex = 6;
            this.btnFiltrarPorCategoria.Text = "Filtrar por Categoria";
            this.btnFiltrarPorCategoria.UseVisualStyleBackColor = true;
            this.btnFiltrarPorCategoria.Click += new System.EventHandler(this.btnFiltrarPorCategoria_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(417, 13);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(75, 23);
            this.btnRecargar.TabIndex = 7;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // FRMProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 355);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnFiltrarPorCategoria);
            this.Controls.Add(this.btnFiltroProveedor);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dataGridProducto);
            this.Name = "FRMProducto";
            this.Text = "FRMProducto";
            this.Load += new System.EventHandler(this.FRMProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProducto;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnFiltroProveedor;
        private System.Windows.Forms.Button btnFiltrarPorCategoria;
        private System.Windows.Forms.Button btnRecargar;
    }
}