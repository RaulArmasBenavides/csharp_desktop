namespace SolRestaurante
{
    partial class EmpleadoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoUI));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.cmbGeneroEmp = new System.Windows.Forms.ComboBox();
            this.cmbCargoEmp = new System.Windows.Forms.ComboBox();
            this.dtgEmpleado = new System.Windows.Forms.DataGridView();
            this.acciones = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtidentificador = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleado)).BeginInit();
            this.acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.Location = new System.Drawing.Point(165, 12);
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Size = new System.Drawing.Size(121, 20);
            this.txtNombreEmp.TabIndex = 8;
            // 
            // cmbGeneroEmp
            // 
            this.cmbGeneroEmp.FormattingEnabled = true;
            this.cmbGeneroEmp.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGeneroEmp.Location = new System.Drawing.Point(165, 38);
            this.cmbGeneroEmp.Name = "cmbGeneroEmp";
            this.cmbGeneroEmp.Size = new System.Drawing.Size(121, 21);
            this.cmbGeneroEmp.TabIndex = 9;
            // 
            // cmbCargoEmp
            // 
            this.cmbCargoEmp.FormattingEnabled = true;
            this.cmbCargoEmp.Items.AddRange(new object[] {
            "Mesero",
            "Cajero"});
            this.cmbCargoEmp.Location = new System.Drawing.Point(165, 65);
            this.cmbCargoEmp.Name = "cmbCargoEmp";
            this.cmbCargoEmp.Size = new System.Drawing.Size(121, 21);
            this.cmbCargoEmp.TabIndex = 10;
            // 
            // dtgEmpleado
            // 
            this.dtgEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleado.Location = new System.Drawing.Point(42, 150);
            this.dtgEmpleado.Name = "dtgEmpleado";
            this.dtgEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEmpleado.Size = new System.Drawing.Size(407, 174);
            this.dtgEmpleado.TabIndex = 12;
            // 
            // acciones
            // 
            this.acciones.Controls.Add(this.btnSalir);
            this.acciones.Controls.Add(this.btnEliminar);
            this.acciones.Controls.Add(this.btnActualizar);
            this.acciones.Controls.Add(this.btnInsertar);
            this.acciones.Location = new System.Drawing.Point(73, 340);
            this.acciones.Name = "acciones";
            this.acciones.Size = new System.Drawing.Size(376, 68);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtidentificador
            // 
            this.txtidentificador.Location = new System.Drawing.Point(120, 123);
            this.txtidentificador.Name = "txtidentificador";
            this.txtidentificador.Size = new System.Drawing.Size(143, 20);
            this.txtidentificador.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "id"});
            this.comboBox1.Location = new System.Drawing.Point(42, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(72, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // dtFecha
            // 
            this.dtFecha.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtFecha.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtFecha.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dtFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(163, 92);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(130, 20);
            this.dtFecha.TabIndex = 22;
            // 
            // EmpleadoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 437);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtidentificador);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.acciones);
            this.Controls.Add(this.dtgEmpleado);
            this.Controls.Add(this.cmbCargoEmp);
            this.Controls.Add(this.cmbGeneroEmp);
            this.Controls.Add(this.txtNombreEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EmpleadoUI";
            this.Text = "MANTENEDOR DE EMPLEADOS";
            this.Load += new System.EventHandler(this.EmpleadoUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleado)).EndInit();
            this.acciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreEmp;
        private System.Windows.Forms.ComboBox cmbGeneroEmp;
        private System.Windows.Forms.ComboBox cmbCargoEmp;
        private System.Windows.Forms.DataGridView dtgEmpleado;
        private System.Windows.Forms.GroupBox acciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtidentificador;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dtFecha;
    }
}