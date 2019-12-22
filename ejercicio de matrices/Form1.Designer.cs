namespace ejercicio_de_matrices
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtempleado1 = new System.Windows.Forms.TextBox();
            this.txtempleado2 = new System.Windows.Forms.TextBox();
            this.txtempleado3 = new System.Windows.Forms.TextBox();
            this.txtempleado4 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtenero = new System.Windows.Forms.TextBox();
            this.txtfebrero = new System.Windows.Forms.TextBox();
            this.txtmarzo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtmayorempleados = new System.Windows.Forms.TextBox();
            this.txtmayormeses = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabla
            // 
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.tabla.Location = new System.Drawing.Point(163, 59);
            this.tabla.Name = "tabla";
            this.tabla.RowTemplate.Height = 28;
            this.tabla.Size = new System.Drawing.Size(508, 292);
            this.tabla.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Enero";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Febrero";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Marzo";
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empleado 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleado 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Empleado 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Empleado 4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ingresar datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtempleado4);
            this.groupBox1.Controls.Add(this.txtempleado3);
            this.groupBox1.Controls.Add(this.txtempleado2);
            this.groupBox1.Controls.Add(this.txtempleado1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(57, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 306);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas totales de empleados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Empleado  4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Empleado 3 ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Empleado 2 ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Empleado 1";
            // 
            // txtempleado1
            // 
            this.txtempleado1.Location = new System.Drawing.Point(172, 69);
            this.txtempleado1.Name = "txtempleado1";
            this.txtempleado1.Size = new System.Drawing.Size(100, 26);
            this.txtempleado1.TabIndex = 14;
            // 
            // txtempleado2
            // 
            this.txtempleado2.Location = new System.Drawing.Point(172, 116);
            this.txtempleado2.Name = "txtempleado2";
            this.txtempleado2.Size = new System.Drawing.Size(100, 26);
            this.txtempleado2.TabIndex = 15;
            // 
            // txtempleado3
            // 
            this.txtempleado3.Location = new System.Drawing.Point(172, 158);
            this.txtempleado3.Name = "txtempleado3";
            this.txtempleado3.Size = new System.Drawing.Size(100, 26);
            this.txtempleado3.TabIndex = 16;
            // 
            // txtempleado4
            // 
            this.txtempleado4.Location = new System.Drawing.Point(172, 205);
            this.txtempleado4.Name = "txtempleado4";
            this.txtempleado4.Size = new System.Drawing.Size(100, 26);
            this.txtempleado4.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmarzo);
            this.groupBox2.Controls.Add(this.txtfebrero);
            this.groupBox2.Controls.Add(this.txtenero);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(462, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 306);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ventas totales de meses";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Enero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Febrero";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Marzo";
            // 
            // txtenero
            // 
            this.txtenero.Location = new System.Drawing.Point(133, 75);
            this.txtenero.Name = "txtenero";
            this.txtenero.Size = new System.Drawing.Size(100, 26);
            this.txtenero.TabIndex = 3;
            // 
            // txtfebrero
            // 
            this.txtfebrero.Location = new System.Drawing.Point(133, 147);
            this.txtfebrero.Name = "txtfebrero";
            this.txtfebrero.Size = new System.Drawing.Size(100, 26);
            this.txtfebrero.TabIndex = 4;
            // 
            // txtmarzo
            // 
            this.txtmarzo.Location = new System.Drawing.Point(133, 208);
            this.txtmarzo.Name = "txtmarzo";
            this.txtmarzo.Size = new System.Drawing.Size(100, 26);
            this.txtmarzo.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtmayormeses);
            this.groupBox3.Controls.Add(this.txtmayorempleados);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(774, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 306);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mayores ventas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Empleados";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(70, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Meses";
            // 
            // txtmayorempleados
            // 
            this.txtmayorempleados.Location = new System.Drawing.Point(46, 98);
            this.txtmayorempleados.Name = "txtmayorempleados";
            this.txtmayorempleados.Size = new System.Drawing.Size(114, 26);
            this.txtmayorempleados.TabIndex = 2;
            // 
            // txtmayormeses
            // 
            this.txtmayormeses.Location = new System.Drawing.Point(46, 208);
            this.txtmayormeses.Name = "txtmayormeses";
            this.txtmayormeses.Size = new System.Drawing.Size(114, 26);
            this.txtmayormeses.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 701);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabla);
            this.Name = "Form1";
            this.Text = "Resumen de ventas";
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtempleado4;
        private System.Windows.Forms.TextBox txtempleado3;
        private System.Windows.Forms.TextBox txtempleado2;
        private System.Windows.Forms.TextBox txtempleado1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmarzo;
        private System.Windows.Forms.TextBox txtfebrero;
        private System.Windows.Forms.TextBox txtenero;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtmayormeses;
        private System.Windows.Forms.TextBox txtmayorempleados;
    }
}

