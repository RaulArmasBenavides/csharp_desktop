namespace Casting.Castings
{
    partial class DetallesContactoCl
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
            this.ced = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idCliente = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ced);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.idCliente);
            this.groupBox1.Controls.Add(this.apellido);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(31, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del contacto";
            // 
            // ced
            // 
            this.ced.Location = new System.Drawing.Point(95, 147);
            this.ced.Name = "ced";
            this.ced.Size = new System.Drawing.Size(131, 20);
            this.ced.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cédula";
            // 
            // idCliente
            // 
            this.idCliente.Location = new System.Drawing.Point(95, 36);
            this.idCliente.Name = "idCliente";
            this.idCliente.Size = new System.Drawing.Size(59, 20);
            this.idCliente.TabIndex = 4;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(95, 110);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(131, 20);
            this.apellido.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(95, 72);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(131, 20);
            this.nombre.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre";
            // 
            // DetallesContactoCl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(320, 252);
            this.Controls.Add(this.groupBox1);
            this.Name = "DetallesContactoCl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.DetallesContactoCl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ced;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idCliente;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;

    }
}