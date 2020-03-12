namespace WinFacturacion
{
    partial class FRMCliente
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnFiltroCiudad = new System.Windows.Forms.Button();
            this.cbCiudades = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(12, 112);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(503, 185);
            this.dgvCliente.TabIndex = 0;
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(32, 29);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(83, 23);
            this.btnMostrarTodo.TabIndex = 1;
            this.btnMostrarTodo.Text = "Mostrar Todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnFiltroCiudad
            // 
            this.btnFiltroCiudad.Location = new System.Drawing.Point(411, 29);
            this.btnFiltroCiudad.Name = "btnFiltroCiudad";
            this.btnFiltroCiudad.Size = new System.Drawing.Size(104, 23);
            this.btnFiltroCiudad.TabIndex = 2;
            this.btnFiltroCiudad.Text = "Mostrar por Ciudad";
            this.btnFiltroCiudad.UseVisualStyleBackColor = true;
            this.btnFiltroCiudad.Click += new System.EventHandler(this.btnFiltroCiudad_Click);
            // 
            // cbCiudades
            // 
            this.cbCiudades.FormattingEnabled = true;
            this.cbCiudades.Location = new System.Drawing.Point(284, 31);
            this.cbCiudades.Name = "cbCiudades";
            this.cbCiudades.Size = new System.Drawing.Size(121, 21);
            this.cbCiudades.TabIndex = 3;
            // 
            // FRMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 309);
            this.Controls.Add(this.cbCiudades);
            this.Controls.Add(this.btnFiltroCiudad);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.dgvCliente);
            this.Name = "FRMCliente";
            this.Load += new System.EventHandler(this.FRMCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnFiltroCiudad;
        private System.Windows.Forms.ComboBox cbCiudades;
    }
}

