namespace CodeFirstNewDatabaseSample
{
    partial class FRMBlog
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
            this.dgvBlogs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreBlog = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnTraerTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBlogs
            // 
            this.dgvBlogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBlogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBlogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlogs.Location = new System.Drawing.Point(115, 140);
            this.dgvBlogs.Name = "dgvBlogs";
            this.dgvBlogs.Size = new System.Drawing.Size(240, 150);
            this.dgvBlogs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese nombre para nuevo Blog: ";
            // 
            // txtNombreBlog
            // 
            this.txtNombreBlog.Location = new System.Drawing.Point(15, 43);
            this.txtNombreBlog.Name = "txtNombreBlog";
            this.txtNombreBlog.Size = new System.Drawing.Size(148, 20);
            this.txtNombreBlog.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 90);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(140, 90);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(271, 90);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnTraerTodo
            // 
            this.btnTraerTodo.Location = new System.Drawing.Point(377, 90);
            this.btnTraerTodo.Name = "btnTraerTodo";
            this.btnTraerTodo.Size = new System.Drawing.Size(75, 23);
            this.btnTraerTodo.TabIndex = 6;
            this.btnTraerTodo.Text = "Traer Todo";
            this.btnTraerTodo.UseVisualStyleBackColor = true;
            // 
            // FRMBlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 302);
            this.Controls.Add(this.btnTraerTodo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreBlog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBlogs);
            this.Name = "FRMBlog";
            this.Text = "Agregar Blog";
            this.Load += new System.EventHandler(this.FRMBlog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBlogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreBlog;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnTraerTodo;
    }
}

