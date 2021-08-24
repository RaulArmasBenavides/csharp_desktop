namespace CapaPresentacion.View
{
    partial class FrmAsistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsistencias));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvAsistencias = new System.Windows.Forms.DataGridView();
            this.Estado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cboDNI = new System.Windows.Forms.ComboBox();
            this.LblDNI = new System.Windows.Forms.Label();
            this.txtappaterno = new System.Windows.Forms.TextBox();
            this.txtapmaterno = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtidListaAsistencias = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.LblLimpiar = new System.Windows.Forms.PictureBox();
            this.LblBuscar = new System.Windows.Forms.PictureBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LblLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de asistencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(100, 44);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // dgvAsistencias
            // 
            this.dgvAsistencias.AllowUserToAddRows = false;
            this.dgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencias.Location = new System.Drawing.Point(45, 180);
            this.dgvAsistencias.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAsistencias.Name = "dgvAsistencias";
            this.dgvAsistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsistencias.Size = new System.Drawing.Size(656, 262);
            this.dgvAsistencias.TabIndex = 5;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(423, 47);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(52, 17);
            this.Estado.TabIndex = 9;
            this.Estado.Text = "Estado";
            this.Estado.Visible = false;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(481, 45);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 22);
            this.txtEstado.TabIndex = 12;
            this.txtEstado.Visible = false;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtnombre);
            this.GroupBox2.Controls.Add(this.cboDNI);
            this.GroupBox2.Controls.Add(this.LblDNI);
            this.GroupBox2.Controls.Add(this.txtappaterno);
            this.GroupBox2.Controls.Add(this.txtapmaterno);
            this.GroupBox2.Controls.Add(this.LblApellido);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Location = new System.Drawing.Point(45, 65);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(699, 107);
            this.GroupBox2.TabIndex = 33;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Datos Asistente";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.Info;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(474, 51);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(203, 22);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboDNI
            // 
            this.cboDNI.BackColor = System.Drawing.SystemColors.Info;
            this.cboDNI.Location = new System.Drawing.Point(21, 49);
            this.cboDNI.Margin = new System.Windows.Forms.Padding(4);
            this.cboDNI.Name = "cboDNI";
            this.cboDNI.Size = new System.Drawing.Size(113, 24);
            this.cboDNI.TabIndex = 2;
            this.cboDNI.SelectedIndexChanged += new System.EventHandler(this.cboDNI_SelectedIndexChanged);
            // 
            // LblDNI
            // 
            this.LblDNI.AutoSize = true;
            this.LblDNI.Location = new System.Drawing.Point(63, 28);
            this.LblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDNI.Name = "LblDNI";
            this.LblDNI.Size = new System.Drawing.Size(31, 17);
            this.LblDNI.TabIndex = 2;
            this.LblDNI.Text = "DNI";
            // 
            // txtappaterno
            // 
            this.txtappaterno.BackColor = System.Drawing.SystemColors.Info;
            this.txtappaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtappaterno.Enabled = false;
            this.txtappaterno.Location = new System.Drawing.Point(142, 50);
            this.txtappaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtappaterno.Name = "txtappaterno";
            this.txtappaterno.ReadOnly = true;
            this.txtappaterno.Size = new System.Drawing.Size(166, 22);
            this.txtappaterno.TabIndex = 0;
            this.txtappaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtapmaterno
            // 
            this.txtapmaterno.BackColor = System.Drawing.SystemColors.Info;
            this.txtapmaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtapmaterno.Enabled = false;
            this.txtapmaterno.Location = new System.Drawing.Point(316, 51);
            this.txtapmaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtapmaterno.Name = "txtapmaterno";
            this.txtapmaterno.ReadOnly = true;
            this.txtapmaterno.Size = new System.Drawing.Size(150, 22);
            this.txtapmaterno.TabIndex = 1;
            this.txtapmaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(158, 28);
            this.LblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(111, 17);
            this.LblApellido.TabIndex = 1;
            this.LblApellido.Text = "Apellido paterno";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(340, 28);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(114, 17);
            this.Label6.TabIndex = 2;
            this.Label6.Text = "Apellido Materno";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(541, 30);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(58, 17);
            this.Label8.TabIndex = 3;
            this.Label8.Text = "Nombre";
            // 
            // txtidListaAsistencias
            // 
            this.txtidListaAsistencias.Enabled = false;
            this.txtidListaAsistencias.Location = new System.Drawing.Point(780, 12);
            this.txtidListaAsistencias.Name = "txtidListaAsistencias";
            this.txtidListaAsistencias.Size = new System.Drawing.Size(100, 22);
            this.txtidListaAsistencias.TabIndex = 36;
            this.txtidListaAsistencias.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnActualizar.Location = new System.Drawing.Point(780, 124);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 46);
            this.btnActualizar.TabIndex = 54;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.Image = global::CapaPresentacion.Properties.Resources.excel_pequeno;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcel.Location = new System.Drawing.Point(780, 223);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(100, 63);
            this.btnExcel.TabIndex = 37;
            this.btnExcel.Text = "A Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // LblLimpiar
            // 
            this.LblLimpiar.ErrorImage = null;
            this.LblLimpiar.Image = global::CapaPresentacion.Properties.Resources.Clean_2;
            this.LblLimpiar.Location = new System.Drawing.Point(239, 43);
            this.LblLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.LblLimpiar.Name = "LblLimpiar";
            this.LblLimpiar.Size = new System.Drawing.Size(24, 24);
            this.LblLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LblLimpiar.TabIndex = 35;
            this.LblLimpiar.TabStop = false;
            this.LblLimpiar.Click += new System.EventHandler(this.LblLimpiar_Click);
            // 
            // LblBuscar
            // 
            this.LblBuscar.Image = ((System.Drawing.Image)(resources.GetObject("LblBuscar.Image")));
            this.LblBuscar.Location = new System.Drawing.Point(207, 44);
            this.LblBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(24, 24);
            this.LblBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LblBuscar.TabIndex = 34;
            this.LblBuscar.TabStop = false;
            this.LblBuscar.Click += new System.EventHandler(this.LblBuscar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::CapaPresentacion.Properties.Resources.Save_as;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGrabar.Location = new System.Drawing.Point(780, 74);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(104, 39);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "Grabar ";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(780, 294);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 70);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(709, 223);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(35, 35);
            this.btnEliminar.TabIndex = 7;
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
            this.btnAgregar.Location = new System.Drawing.Point(709, 180);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(35, 35);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(780, 176);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(104, 39);
            this.btnAnular.TabIndex = 55;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVolver.Location = new System.Drawing.Point(780, 371);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 47);
            this.btnVolver.TabIndex = 58;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(909, 455);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.txtidListaAsistencias);
            this.Controls.Add(this.LblLimpiar);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvAsistencias);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAsistencias";
            this.Text = ":: REGISTRO DE ASISTENCIAS ::";
            this.Load += new System.EventHandler(this.FrmAsistencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LblLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvAsistencias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtEstado;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtnombre;
        internal System.Windows.Forms.ComboBox cboDNI;
        internal System.Windows.Forms.Label LblDNI;
        internal System.Windows.Forms.TextBox txtappaterno;
        internal System.Windows.Forms.TextBox txtapmaterno;
        internal System.Windows.Forms.Label LblApellido;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label8;
        private System.Windows.Forms.PictureBox LblLimpiar;
        private System.Windows.Forms.PictureBox LblBuscar;
        internal System.Windows.Forms.TextBox txtidListaAsistencias;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnVolver;
    }
}