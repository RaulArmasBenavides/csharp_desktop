namespace proysustiCliente
{
    partial class ActaCompromisoUI
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
            this.txtAC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRD = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.npdNumDias = new System.Windows.Forms.NumericUpDown();
            this.lblTipoGasto = new System.Windows.Forms.Label();
            this.cmbTipoGasto = new System.Windows.Forms.ComboBox();
            this.dtgacta = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGurdar = new System.Windows.Forms.Button();
            this.dtpFechaRD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaAC = new System.Windows.Forms.DateTimePicker();
            this.cmbPersonal = new System.Windows.Forms.ComboBox();
            this.txtIdPersonal = new System.Windows.Forms.TextBox();
            this.Personal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.npdNumDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgacta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "NumAC";
            // 
            // txtAC
            // 
            this.txtAC.Location = new System.Drawing.Point(181, 36);
            this.txtAC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAC.Name = "txtAC";
            this.txtAC.Size = new System.Drawing.Size(132, 22);
            this.txtAC.TabIndex = 2;
            this.txtAC.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resolución Decanal";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtRD
            // 
            this.txtRD.Location = new System.Drawing.Point(181, 68);
            this.txtRD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRD.MaxLength = 10;
            this.txtRD.Name = "txtRD";
            this.txtRD.Size = new System.Drawing.Size(132, 22);
            this.txtRD.TabIndex = 4;
            this.txtRD.TextChanged += new System.EventHandler(this.txtCI_TextChanged);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(181, 100);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(132, 22);
            this.txtMonto.TabIndex = 6;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(108, 108);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(47, 17);
            this.lblMonto.TabIndex = 8;
            this.lblMonto.Text = "Monto";
            this.lblMonto.Click += new System.EventHandler(this.lblMonto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Número Días";
            // 
            // npdNumDias
            // 
            this.npdNumDias.Location = new System.Drawing.Point(181, 172);
            this.npdNumDias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npdNumDias.Name = "npdNumDias";
            this.npdNumDias.Size = new System.Drawing.Size(53, 22);
            this.npdNumDias.TabIndex = 11;
            // 
            // lblTipoGasto
            // 
            this.lblTipoGasto.AutoSize = true;
            this.lblTipoGasto.Location = new System.Drawing.Point(323, 108);
            this.lblTipoGasto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoGasto.Name = "lblTipoGasto";
            this.lblTipoGasto.Size = new System.Drawing.Size(82, 17);
            this.lblTipoGasto.TabIndex = 12;
            this.lblTipoGasto.Text = "Tipo. Gasto";
            // 
            // cmbTipoGasto
            // 
            this.cmbTipoGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoGasto.FormattingEnabled = true;
            this.cmbTipoGasto.Items.AddRange(new object[] {
            "Viáticos",
            "Encargos"});
            this.cmbTipoGasto.Location = new System.Drawing.Point(409, 103);
            this.cmbTipoGasto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoGasto.Name = "cmbTipoGasto";
            this.cmbTipoGasto.Size = new System.Drawing.Size(132, 24);
            this.cmbTipoGasto.TabIndex = 13;
            // 
            // dtgacta
            // 
            this.dtgacta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgacta.Location = new System.Drawing.Point(41, 270);
            this.dtgacta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgacta.Name = "dtgacta";
            this.dtgacta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgacta.Size = new System.Drawing.Size(583, 167);
            this.dtgacta.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnGurdar);
            this.groupBox1.Location = new System.Drawing.Point(41, 444);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(583, 59);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(349, 20);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(241, 20);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "&Borrar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(133, 20);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 28);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGurdar
            // 
            this.btnGurdar.Location = new System.Drawing.Point(25, 20);
            this.btnGurdar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGurdar.Name = "btnGurdar";
            this.btnGurdar.Size = new System.Drawing.Size(100, 28);
            this.btnGurdar.TabIndex = 0;
            this.btnGurdar.Text = "&Guardar";
            this.btnGurdar.UseVisualStyleBackColor = true;
            this.btnGurdar.Click += new System.EventHandler(this.btnGurdar_Click);
            // 
            // dtpFechaRD
            // 
            this.dtpFechaRD.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpFechaRD.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtpFechaRD.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dtpFechaRD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaRD.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaRD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRD.Location = new System.Drawing.Point(409, 68);
            this.dtpFechaRD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaRD.Name = "dtpFechaRD";
            this.dtpFechaRD.Size = new System.Drawing.Size(172, 22);
            this.dtpFechaRD.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fecha R.D";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(181, 140);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMotivo.MaxLength = 10;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(441, 22);
            this.txtMotivo.TabIndex = 25;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(105, 144);
            this.lblMotivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(49, 17);
            this.lblMotivo.TabIndex = 26;
            this.lblMotivo.Text = "Motivo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 204);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 22);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateTimePicker2.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(451, 204);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(172, 22);
            this.dateTimePicker2.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fec.Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fec.Final";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Fecha A.C";
            // 
            // dtpFechaAC
            // 
            this.dtpFechaAC.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpFechaAC.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtpFechaAC.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dtpFechaAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaAC.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaAC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAC.Location = new System.Drawing.Point(409, 36);
            this.dtpFechaAC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaAC.Name = "dtpFechaAC";
            this.dtpFechaAC.Size = new System.Drawing.Size(172, 22);
            this.dtpFechaAC.TabIndex = 32;
            this.dtpFechaAC.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // cmbPersonal
            // 
            this.cmbPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonal.FormattingEnabled = true;
            this.cmbPersonal.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbPersonal.Location = new System.Drawing.Point(181, 236);
            this.cmbPersonal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.Size = new System.Drawing.Size(132, 24);
            this.cmbPersonal.TabIndex = 33;
            // 
            // txtIdPersonal
            // 
            this.txtIdPersonal.Location = new System.Drawing.Point(331, 238);
            this.txtIdPersonal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdPersonal.Name = "txtIdPersonal";
            this.txtIdPersonal.Size = new System.Drawing.Size(57, 22);
            this.txtIdPersonal.TabIndex = 34;
            // 
            // Personal
            // 
            this.Personal.AutoSize = true;
            this.Personal.Location = new System.Drawing.Point(101, 241);
            this.Personal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(64, 17);
            this.Personal.TabIndex = 35;
            this.Personal.Text = "Personal";
            // 
            // ActaCompromisoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 511);
            this.Controls.Add(this.Personal);
            this.Controls.Add(this.txtIdPersonal);
            this.Controls.Add(this.cmbPersonal);
            this.Controls.Add(this.dtpFechaAC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaRD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgacta);
            this.Controls.Add(this.cmbTipoGasto);
            this.Controls.Add(this.lblTipoGasto);
            this.Controls.Add(this.npdNumDias);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAC);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ActaCompromisoUI";
            this.Text = "Acta de Compromiso";
            this.Load += new System.EventHandler(this.actaUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.npdNumDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgacta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRD;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown npdNumDias;
        private System.Windows.Forms.Label lblTipoGasto;
        private System.Windows.Forms.ComboBox cmbTipoGasto;
        private System.Windows.Forms.DataGridView dtgacta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGurdar;
        private System.Windows.Forms.DateTimePicker dtpFechaRD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaAC;
        private System.Windows.Forms.ComboBox cmbPersonal;
        private System.Windows.Forms.TextBox txtIdPersonal;
        private System.Windows.Forms.Label Personal;
    }
}