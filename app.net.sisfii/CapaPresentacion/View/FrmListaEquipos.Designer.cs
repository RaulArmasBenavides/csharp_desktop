namespace CapaPresentacion.View
{
    partial class FrmListaEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaEquipos));
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RAM = new System.Windows.Forms.Label();
            this.LblTM = new System.Windows.Forms.Label();
            this.txtTM = new System.Windows.Forms.TextBox();
            this.txtProcesador = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.txtSO = new System.Windows.Forms.TextBox();
            this.cboEquipo = new System.Windows.Forms.ComboBox();
            this.LblNombreEquipo = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.Label();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidListaEquipo = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.LblLimpiar = new System.Windows.Forms.PictureBox();
            this.LblBuscar = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.label5);
            this.GroupBox2.Controls.Add(this.label4);
            this.GroupBox2.Controls.Add(this.RAM);
            this.GroupBox2.Controls.Add(this.LblTM);
            this.GroupBox2.Controls.Add(this.txtTM);
            this.GroupBox2.Controls.Add(this.txtProcesador);
            this.GroupBox2.Controls.Add(this.txtRAM);
            this.GroupBox2.Controls.Add(this.txtSO);
            this.GroupBox2.Controls.Add(this.cboEquipo);
            this.GroupBox2.Controls.Add(this.LblNombreEquipo);
            this.GroupBox2.Location = new System.Drawing.Point(58, 85);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(935, 98);
            this.GroupBox2.TabIndex = 46;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Datos Equipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "SO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Procesador";
            // 
            // RAM
            // 
            this.RAM.AutoSize = true;
            this.RAM.Location = new System.Drawing.Point(621, 28);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(38, 17);
            this.RAM.TabIndex = 58;
            this.RAM.Text = "RAM";
            // 
            // LblTM
            // 
            this.LblTM.AutoSize = true;
            this.LblTM.Location = new System.Drawing.Point(621, 59);
            this.LblTM.Name = "LblTM";
            this.LblTM.Size = new System.Drawing.Size(28, 17);
            this.LblTM.TabIndex = 54;
            this.LblTM.Text = "TM";
            // 
            // txtTM
            // 
            this.txtTM.Enabled = false;
            this.txtTM.Location = new System.Drawing.Point(685, 56);
            this.txtTM.Name = "txtTM";
            this.txtTM.Size = new System.Drawing.Size(163, 22);
            this.txtTM.TabIndex = 57;
            // 
            // txtProcesador
            // 
            this.txtProcesador.Enabled = false;
            this.txtProcesador.Location = new System.Drawing.Point(306, 56);
            this.txtProcesador.Name = "txtProcesador";
            this.txtProcesador.Size = new System.Drawing.Size(163, 22);
            this.txtProcesador.TabIndex = 56;
            // 
            // txtRAM
            // 
            this.txtRAM.Enabled = false;
            this.txtRAM.Location = new System.Drawing.Point(685, 28);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(163, 22);
            this.txtRAM.TabIndex = 55;
            // 
            // txtSO
            // 
            this.txtSO.Enabled = false;
            this.txtSO.Location = new System.Drawing.Point(306, 28);
            this.txtSO.Name = "txtSO";
            this.txtSO.Size = new System.Drawing.Size(163, 22);
            this.txtSO.TabIndex = 54;
            // 
            // cboEquipo
            // 
            this.cboEquipo.BackColor = System.Drawing.SystemColors.Info;
            this.cboEquipo.Location = new System.Drawing.Point(21, 49);
            this.cboEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.cboEquipo.Name = "cboEquipo";
            this.cboEquipo.Size = new System.Drawing.Size(113, 24);
            this.cboEquipo.TabIndex = 2;
            this.cboEquipo.SelectedIndexChanged += new System.EventHandler(this.cboDNI_SelectedIndexChanged);
            // 
            // LblNombreEquipo
            // 
            this.LblNombreEquipo.AutoSize = true;
            this.LblNombreEquipo.Location = new System.Drawing.Point(18, 28);
            this.LblNombreEquipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreEquipo.Name = "LblNombreEquipo";
            this.LblNombreEquipo.Size = new System.Drawing.Size(100, 17);
            this.LblNombreEquipo.TabIndex = 2;
            this.LblNombreEquipo.Text = "Codigo Equipo";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(494, 56);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 22);
            this.txtEstado.TabIndex = 45;
            this.txtEstado.Visible = false;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(436, 56);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(52, 17);
            this.Estado.TabIndex = 43;
            this.Estado.Text = "Estado";
            this.Estado.Visible = false;
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.AllowUserToAddRows = false;
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Location = new System.Drawing.Point(58, 191);
            this.dgvEquipos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipos.Size = new System.Drawing.Size(935, 280);
            this.dgvEquipos.TabIndex = 39;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(113, 52);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Lista de equipos";
            // 
            // txtidListaEquipo
            // 
            this.txtidListaEquipo.Enabled = false;
            this.txtidListaEquipo.Location = new System.Drawing.Point(932, 21);
            this.txtidListaEquipo.Name = "txtidListaEquipo";
            this.txtidListaEquipo.Size = new System.Drawing.Size(100, 22);
            this.txtidListaEquipo.TabIndex = 49;
            this.txtidListaEquipo.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnActualizar.Location = new System.Drawing.Point(1095, 144);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 47);
            this.btnActualizar.TabIndex = 53;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.Image = global::CapaPresentacion.Properties.Resources.excel_pequeno;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExcel.Location = new System.Drawing.Point(1095, 244);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(104, 64);
            this.btnExcel.TabIndex = 52;
            this.btnExcel.Text = "A Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::CapaPresentacion.Properties.Resources.Save_as;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGrabar.Location = new System.Drawing.Point(1095, 85);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(104, 51);
            this.btnGrabar.TabIndex = 51;
            this.btnGrabar.Text = "Grabar ";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click_1);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(1095, 316);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(104, 72);
            this.btnImprimir.TabIndex = 50;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // LblLimpiar
            // 
            this.LblLimpiar.ErrorImage = null;
            this.LblLimpiar.Image = global::CapaPresentacion.Properties.Resources.Clean_2;
            this.LblLimpiar.Location = new System.Drawing.Point(252, 52);
            this.LblLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.LblLimpiar.Name = "LblLimpiar";
            this.LblLimpiar.Size = new System.Drawing.Size(24, 24);
            this.LblLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LblLimpiar.TabIndex = 48;
            this.LblLimpiar.TabStop = false;
            this.LblLimpiar.Click += new System.EventHandler(this.LblLimpiar_Click);
            // 
            // LblBuscar
            // 
            this.LblBuscar.Image = ((System.Drawing.Image)(resources.GetObject("LblBuscar.Image")));
            this.LblBuscar.Location = new System.Drawing.Point(220, 52);
            this.LblBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(24, 24);
            this.LblBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LblBuscar.TabIndex = 47;
            this.LblBuscar.TabStop = false;
            this.LblBuscar.Click += new System.EventHandler(this.LblBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(1001, 228);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(31, 32);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(1001, 191);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(31, 29);
            this.btnAgregar.TabIndex = 40;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1094, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 39);
            this.button1.TabIndex = 56;
            this.button1.Text = "Anular";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVolver.Location = new System.Drawing.Point(1095, 395);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(104, 44);
            this.btnVolver.TabIndex = 57;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmListaEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1211, 484);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtidListaEquipo);
            this.Controls.Add(this.LblLimpiar);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmListaEquipos";
            this.Text = ":: REGISTRO DE LISTA DE EQUIPOS ::";
            this.Load += new System.EventHandler(this.FrmListaEquipos_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LblLimpiar;
        private System.Windows.Forms.PictureBox LblBuscar;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.ComboBox cboEquipo;
        internal System.Windows.Forms.Label LblNombreEquipo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtidListaEquipo;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RAM;
        private System.Windows.Forms.Label LblTM;
        private System.Windows.Forms.TextBox txtTM;
        private System.Windows.Forms.TextBox txtProcesador;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtSO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVolver;
    }
}