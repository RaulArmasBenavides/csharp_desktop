namespace Neptuno.Libreria.AppWind.Formularios
{
    partial class frmRegistraVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgdDetalle = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEliminaDetalle = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDetalle)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgdDetalle
            // 
            this.dgdDetalle.AllowUserToAddRows = false;
            this.dgdDetalle.AllowUserToDeleteRows = false;
            this.dgdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgdDetalle.Location = new System.Drawing.Point(14, 182);
            this.dgdDetalle.Name = "dgdDetalle";
            this.dgdDetalle.ReadOnly = true;
            this.dgdDetalle.Size = new System.Drawing.Size(420, 176);
            this.dgdDetalle.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Codigo";
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle57;
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nombre";
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 145;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Precio";
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle58.Format = "N2";
            dataGridViewCellStyle58.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle58;
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Cantidad";
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle59.Format = "N0";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle59;
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Subtotal";
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle60.Format = "N2";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle60;
            this.Column5.HeaderText = "Subtotal";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(441, 286);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(96, 24);
            this.btnImprimir.TabIndex = 39;
            this.btnImprimir.Text = "Imprimir";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(338, 362);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(96, 20);
            this.txtTotal.TabIndex = 38;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(234, 364);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(98, 18);
            this.Label10.TabIndex = 37;
            this.Label10.Text = "Valor Total Venta";
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(441, 318);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(96, 23);
            this.btnCerrar.TabIndex = 36;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Location = new System.Drawing.Point(441, 254);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(96, 23);
            this.btnGrabar.TabIndex = 35;
            this.btnGrabar.Text = "&Grabar Venta";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnEliminaDetalle
            // 
            this.btnEliminaDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaDetalle.Location = new System.Drawing.Point(441, 222);
            this.btnEliminaDetalle.Name = "btnEliminaDetalle";
            this.btnEliminaDetalle.Size = new System.Drawing.Size(96, 23);
            this.btnEliminaDetalle.TabIndex = 34;
            this.btnEliminaDetalle.Text = "&Eliminar Detalle";
            this.btnEliminaDetalle.Click += new System.EventHandler(this.btnEliminaDetalle_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(441, 190);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 23);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "&Agregar Detalle";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtSubTotal);
            this.GroupBox2.Controls.Add(this.txtCantidad);
            this.GroupBox2.Controls.Add(this.cboProducto);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.txtCodigo);
            this.GroupBox2.Controls.Add(this.txtPrecio);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Location = new System.Drawing.Point(12, 96);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(524, 80);
            this.GroupBox2.TabIndex = 32;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Datos del Detalle";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(432, 40);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(80, 20);
            this.txtSubTotal.TabIndex = 4;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Info;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Location = new System.Drawing.Point(360, 40);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(60, 20);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // cboProducto
            // 
            this.cboProducto.BackColor = System.Drawing.SystemColors.Info;
            this.cboProducto.Location = new System.Drawing.Point(16, 40);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(192, 21);
            this.cboProducto.TabIndex = 2;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(85, 21);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(50, 13);
            this.Label7.TabIndex = 2;
            this.Label7.Text = "Producto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Info;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(215, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(58, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.Info;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(286, 40);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(64, 20);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(226, 23);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(40, 13);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "Codigo";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(301, 23);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(37, 13);
            this.Label6.TabIndex = 2;
            this.Label6.Text = "Precio";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(367, 23);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(49, 13);
            this.Label8.TabIndex = 3;
            this.Label8.Text = "Cantidad";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(448, 23);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(50, 13);
            this.Label9.TabIndex = 3;
            this.Label9.Text = "SubTotal";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cboCliente);
            this.GroupBox1.Controls.Add(this.cboEmpleado);
            this.GroupBox1.Controls.Add(this.txtNro);
            this.GroupBox1.Controls.Add(this.txtFecha);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(525, 80);
            this.GroupBox1.TabIndex = 31;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Datos del Venta";
            // 
            // cboCliente
            // 
            this.cboCliente.BackColor = System.Drawing.SystemColors.Info;
            this.cboCliente.Location = new System.Drawing.Point(344, 40);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(168, 21);
            this.cboCliente.TabIndex = 3;
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.BackColor = System.Drawing.SystemColors.Info;
            this.cboEmpleado.Location = new System.Drawing.Point(176, 40);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(160, 21);
            this.cboEmpleado.TabIndex = 2;
            // 
            // txtNro
            // 
            this.txtNro.BackColor = System.Drawing.SystemColors.Info;
            this.txtNro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNro.Enabled = false;
            this.txtNro.Location = new System.Drawing.Point(24, 40);
            this.txtNro.Name = "txtNro";
            this.txtNro.ReadOnly = true;
            this.txtNro.Size = new System.Drawing.Size(56, 20);
            this.txtNro.TabIndex = 0;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Info;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(88, 40);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(80, 20);
            this.txtFecha.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(31, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Numero";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(112, 22);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(37, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Fecha";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(225, 23);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(54, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Empleado";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(400, 22);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(39, 13);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Cliente";
            // 
            // frmRegistraVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 399);
            this.Controls.Add(this.dgdDetalle);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnEliminaDetalle);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistraVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registra Ventas";
            this.Load += new System.EventHandler(this.frmRegistraVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdDetalle)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgdDetalle;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        internal System.Windows.Forms.Button btnImprimir;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Button btnCerrar;
        internal System.Windows.Forms.Button btnGrabar;
        internal System.Windows.Forms.Button btnEliminaDetalle;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtSubTotal;
        internal System.Windows.Forms.TextBox txtCantidad;
        internal System.Windows.Forms.ComboBox cboProducto;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.TextBox txtPrecio;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox cboCliente;
        internal System.Windows.Forms.ComboBox cboEmpleado;
        internal System.Windows.Forms.TextBox txtNro;
        internal System.Windows.Forms.TextBox txtFecha;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
    }
}