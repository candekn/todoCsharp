namespace Ejercicio_4
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbdDivision = new System.Windows.Forms.RadioButton();
            this.rbdMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rbdResta = new System.Windows.Forms.RadioButton();
            this.rdbSuma = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResultado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNum2);
            this.groupBox1.Controls.Add(this.txtNum1);
            this.groupBox1.Controls.Add(this.lblNum2);
            this.groupBox1.Controls.Add(this.lblNum1);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada de datos";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(68, 132);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resultado:";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(68, 84);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 3;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(68, 38);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 2;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(6, 87);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(56, 13);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Numero 2:";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(6, 41);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(56, 13);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Numero 1:";
            this.lblNum1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbdDivision);
            this.groupBox2.Controls.Add(this.rbdMultiplicacion);
            this.groupBox2.Controls.Add(this.rbdResta);
            this.groupBox2.Controls.Add(this.rdbSuma);
            this.groupBox2.Location = new System.Drawing.Point(207, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar operacion:";
            // 
            // rbdDivision
            // 
            this.rbdDivision.AutoSize = true;
            this.rbdDivision.Location = new System.Drawing.Point(14, 87);
            this.rbdDivision.Name = "rbdDivision";
            this.rbdDivision.Size = new System.Drawing.Size(62, 17);
            this.rbdDivision.TabIndex = 3;
            this.rbdDivision.Text = "Division";
            this.rbdDivision.UseVisualStyleBackColor = true;
            // 
            // rbdMultiplicacion
            // 
            this.rbdMultiplicacion.AutoSize = true;
            this.rbdMultiplicacion.Location = new System.Drawing.Point(14, 110);
            this.rbdMultiplicacion.Name = "rbdMultiplicacion";
            this.rbdMultiplicacion.Size = new System.Drawing.Size(89, 17);
            this.rbdMultiplicacion.TabIndex = 2;
            this.rbdMultiplicacion.Text = "Multiplicacion";
            this.rbdMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rbdResta
            // 
            this.rbdResta.AutoSize = true;
            this.rbdResta.Location = new System.Drawing.Point(14, 64);
            this.rbdResta.Name = "rbdResta";
            this.rbdResta.Size = new System.Drawing.Size(53, 17);
            this.rbdResta.TabIndex = 1;
            this.rbdResta.Text = "Resta";
            this.rbdResta.UseVisualStyleBackColor = true;
            // 
            // rdbSuma
            // 
            this.rdbSuma.AutoSize = true;
            this.rdbSuma.Checked = true;
            this.rdbSuma.Location = new System.Drawing.Point(14, 41);
            this.rdbSuma.Name = "rdbSuma";
            this.rdbSuma.Size = new System.Drawing.Size(52, 17);
            this.rdbSuma.TabIndex = 0;
            this.rdbSuma.TabStop = true;
            this.rdbSuma.Text = "Suma";
            this.rdbSuma.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(221, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(99, 220);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(87, 32);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Mostrar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 264);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbdDivision;
        private System.Windows.Forms.RadioButton rbdMultiplicacion;
        private System.Windows.Forms.RadioButton rbdResta;
        private System.Windows.Forms.RadioButton rdbSuma;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
    }
}

