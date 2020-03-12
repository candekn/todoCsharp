namespace Ejercicio2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbln2 = new System.Windows.Forms.Label();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblResta = new System.Windows.Forms.Label();
            this.lblMultiplicacion = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.lblRaiz = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.txtn2);
            this.groupBox1.Controls.Add(this.txtn1);
            this.groupBox1.Controls.Add(this.lbln2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Location = new System.Drawing.Point(45, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Datos";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.lblRaiz);
            this.groupBox2.Controls.Add(this.lblPotencia);
            this.groupBox2.Controls.Add(this.lblDivision);
            this.groupBox2.Controls.Add(this.lblMultiplicacion);
            this.groupBox2.Controls.Add(this.lblResta);
            this.groupBox2.Controls.Add(this.lblSuma);
            this.groupBox2.Location = new System.Drawing.Point(360, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 245);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl1.Location = new System.Drawing.Point(17, 47);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(56, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Numero 1:";
            // 
            // lbln2
            // 
            this.lbln2.AutoSize = true;
            this.lbln2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbln2.Location = new System.Drawing.Point(17, 93);
            this.lbln2.Name = "lbln2";
            this.lbln2.Size = new System.Drawing.Size(56, 13);
            this.lbln2.TabIndex = 1;
            this.lbln2.Text = "Numero 2:";
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(79, 44);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(114, 20);
            this.txtn1.TabIndex = 2;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(79, 90);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(114, 20);
            this.txtn2.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(20, 150);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(62, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(201, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(112, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSuma.Location = new System.Drawing.Point(35, 35);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(37, 13);
            this.lblSuma.TabIndex = 7;
            this.lblSuma.Text = "Suma:";
            this.lblSuma.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblResta
            // 
            this.lblResta.AutoSize = true;
            this.lblResta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResta.Location = new System.Drawing.Point(35, 66);
            this.lblResta.Name = "lblResta";
            this.lblResta.Size = new System.Drawing.Size(38, 13);
            this.lblResta.TabIndex = 8;
            this.lblResta.Text = "Resta:";
            // 
            // lblMultiplicacion
            // 
            this.lblMultiplicacion.AutoSize = true;
            this.lblMultiplicacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMultiplicacion.Location = new System.Drawing.Point(35, 97);
            this.lblMultiplicacion.Name = "lblMultiplicacion";
            this.lblMultiplicacion.Size = new System.Drawing.Size(74, 13);
            this.lblMultiplicacion.TabIndex = 9;
            this.lblMultiplicacion.Text = "Multiplicacion:";
            this.lblMultiplicacion.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDivision.Location = new System.Drawing.Point(35, 132);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(47, 13);
            this.lblDivision.TabIndex = 10;
            this.lblDivision.Text = "Division:";
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPotencia.Location = new System.Drawing.Point(35, 169);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(52, 13);
            this.lblPotencia.TabIndex = 11;
            this.lblPotencia.Text = "Potencia:";
            // 
            // lblRaiz
            // 
            this.lblRaiz.AutoSize = true;
            this.lblRaiz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRaiz.Location = new System.Drawing.Point(35, 205);
            this.lblRaiz.Name = "lblRaiz";
            this.lblRaiz.Size = new System.Drawing.Size(31, 13);
            this.lblRaiz.TabIndex = 12;
            this.lblRaiz.Text = "Raiz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(620, 322);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.Label lbln2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblRaiz;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblMultiplicacion;
        private System.Windows.Forms.Label lblResta;
    }
}

