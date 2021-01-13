namespace com.app.comprobante.UI
{
    partial class PersonalUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.dtgPersonal = new System.Windows.Forms.DataGridView();
            this.acciones = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtidentificador = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCAbono = new System.Windows.Forms.TextBox();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.txtApeMat = new System.Windows.Forms.TextBox();
            this.txtApePat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelf1 = new System.Windows.Forms.TextBox();
            this.txtTelf2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelf3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonal)).BeginInit();
            this.acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2 Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telf.1";
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(343, 38);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(128, 20);
            this.txtNombre2.TabIndex = 8;
            this.txtNombre2.TextChanged += new System.EventHandler(this.txtNombreEmp_TextChanged);
            // 
            // dtgPersonal
            // 
            this.dtgPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPersonal.Location = new System.Drawing.Point(74, 221);
            this.dtgPersonal.Name = "dtgPersonal";
            this.dtgPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPersonal.Size = new System.Drawing.Size(407, 174);
            this.dtgPersonal.TabIndex = 12;
            this.dtgPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmpleado_CellContentClick);
            // 
            // acciones
            // 
            this.acciones.Controls.Add(this.btnSalir);
            this.acciones.Controls.Add(this.btnEliminar);
            this.acciones.Controls.Add(this.btnActualizar);
            this.acciones.Controls.Add(this.btnInsertar);
            this.acciones.Location = new System.Drawing.Point(95, 401);
            this.acciones.Name = "acciones";
            this.acciones.Size = new System.Drawing.Size(376, 58);
            this.acciones.TabIndex = 13;
            this.acciones.TabStop = false;
            this.acciones.Text = "Acciones";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(280, 27);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(199, 27);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(118, 27);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(37, 27);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtidentificador
            // 
            this.txtidentificador.Location = new System.Drawing.Point(152, 194);
            this.txtidentificador.Name = "txtidentificador";
            this.txtidentificador.Size = new System.Drawing.Size(143, 20);
            this.txtidentificador.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "id"});
            this.comboBox1.Location = new System.Drawing.Point(74, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(72, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(301, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(343, 152);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(121, 20);
            this.txtCorreo.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Cuenta Abono";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtCAbono
            // 
            this.txtCAbono.Location = new System.Drawing.Point(130, 152);
            this.txtCAbono.Name = "txtCAbono";
            this.txtCAbono.Size = new System.Drawing.Size(121, 20);
            this.txtCAbono.TabIndex = 27;
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(130, 39);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(121, 20);
            this.txtNombre1.TabIndex = 28;
            this.txtNombre1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtApeMat
            // 
            this.txtApeMat.Location = new System.Drawing.Point(341, 12);
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.Size = new System.Drawing.Size(130, 20);
            this.txtApeMat.TabIndex = 29;
            this.txtApeMat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtApePat
            // 
            this.txtApePat.Location = new System.Drawing.Point(130, 12);
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.Size = new System.Drawing.Size(121, 20);
            this.txtApePat.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "1 Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Apellido Pat.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(268, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Apellido Mat.";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(130, 65);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(341, 20);
            this.txtDomicilio.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Domiciio";
            // 
            // txtTelf1
            // 
            this.txtTelf1.Location = new System.Drawing.Point(130, 91);
            this.txtTelf1.Name = "txtTelf1";
            this.txtTelf1.Size = new System.Drawing.Size(121, 20);
            this.txtTelf1.TabIndex = 36;
            // 
            // txtTelf2
            // 
            this.txtTelf2.Location = new System.Drawing.Point(350, 91);
            this.txtTelf2.Name = "txtTelf2";
            this.txtTelf2.Size = new System.Drawing.Size(121, 20);
            this.txtTelf2.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Telf.2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Telf.3";
            // 
            // txtTelf3
            // 
            this.txtTelf3.Location = new System.Drawing.Point(130, 120);
            this.txtTelf3.Name = "txtTelf3";
            this.txtTelf3.Size = new System.Drawing.Size(121, 20);
            this.txtTelf3.TabIndex = 40;
            // 
            // EmpleadoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 476);
            this.Controls.Add(this.txtTelf3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelf2);
            this.Controls.Add(this.txtTelf1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApePat);
            this.Controls.Add(this.txtApeMat);
            this.Controls.Add(this.txtNombre1);
            this.Controls.Add(this.txtCAbono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtidentificador);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.acciones);
            this.Controls.Add(this.dtgPersonal);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "EmpleadoUI";
            this.Text = "Mantenedor de Personal";
            this.Load += new System.EventHandler(this.EmpleadoUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonal)).EndInit();
            this.acciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.DataGridView dtgPersonal;
        private System.Windows.Forms.GroupBox acciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtidentificador;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCAbono;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.TextBox txtApeMat;
        private System.Windows.Forms.TextBox txtApePat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelf1;
        private System.Windows.Forms.TextBox txtTelf2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelf3;
    }
}