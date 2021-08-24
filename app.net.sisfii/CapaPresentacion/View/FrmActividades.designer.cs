namespace CapaDatos.View
{
    partial class FrmActividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActividades));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblLimpiar = new System.Windows.Forms.PictureBox();
            this.LblBuscar = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboListaEquipos = new System.Windows.Forms.ComboBox();
            this.cboAsistencias = new System.Windows.Forms.ComboBox();
            this.btnListaAsistenci = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboSala = new System.Windows.Forms.ComboBox();
            this.dtpicker2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnListaEquipos = new System.Windows.Forms.Button();
            this.txtrolresponsable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombreactividad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.txtidActividades = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LblLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblBuscar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtidActividades);
            this.groupBox1.Controls.Add(this.LblLimpiar);
            this.groupBox1.Controls.Add(this.LblBuscar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Location = new System.Drawing.Point(35, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1058, 527);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la actividad";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LblLimpiar
            // 
            this.LblLimpiar.Image = global::CapaPresentacion.Properties.Resources.Clean_2;
            this.LblLimpiar.Location = new System.Drawing.Point(344, 23);
            this.LblLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.LblLimpiar.Name = "LblLimpiar";
            this.LblLimpiar.Size = new System.Drawing.Size(24, 24);
            this.LblLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LblLimpiar.TabIndex = 36;
            this.LblLimpiar.TabStop = false;
            this.LblLimpiar.Click += new System.EventHandler(this.LblLimpiar_Click);
            // 
            // LblBuscar
            // 
            this.LblBuscar.Image = ((System.Drawing.Image)(resources.GetObject("LblBuscar.Image")));
            this.LblBuscar.Location = new System.Drawing.Point(312, 23);
            this.LblBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(24, 24);
            this.LblBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LblBuscar.TabIndex = 35;
            this.LblBuscar.TabStop = false;
            this.LblBuscar.Click += new System.EventHandler(this.LblBuscar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboListaEquipos);
            this.groupBox3.Controls.Add(this.cboAsistencias);
            this.groupBox3.Controls.Add(this.btnListaAsistenci);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cboSala);
            this.groupBox3.Controls.Add(this.dtpicker2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dtpicker1);
            this.groupBox3.Controls.Add(this.btnListaEquipos);
            this.groupBox3.Controls.Add(this.txtrolresponsable);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtDescripcion);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtnombreactividad);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(30, 55);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(991, 446);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles";
            // 
            // cboListaEquipos
            // 
            this.cboListaEquipos.FormattingEnabled = true;
            this.cboListaEquipos.Location = new System.Drawing.Point(166, 198);
            this.cboListaEquipos.Margin = new System.Windows.Forms.Padding(4);
            this.cboListaEquipos.Name = "cboListaEquipos";
            this.cboListaEquipos.Size = new System.Drawing.Size(729, 24);
            this.cboListaEquipos.TabIndex = 10022;
            // 
            // cboAsistencias
            // 
            this.cboAsistencias.FormattingEnabled = true;
            this.cboAsistencias.Location = new System.Drawing.Point(166, 162);
            this.cboAsistencias.Margin = new System.Windows.Forms.Padding(4);
            this.cboAsistencias.Name = "cboAsistencias";
            this.cboAsistencias.Size = new System.Drawing.Size(729, 24);
            this.cboAsistencias.TabIndex = 10021;
            this.cboAsistencias.SelectedIndexChanged += new System.EventHandler(this.cboAsistencias_SelectedIndexChanged);
            // 
            // btnListaAsistenci
            // 
            this.btnListaAsistenci.Image = ((System.Drawing.Image)(resources.GetObject("btnListaAsistenci.Image")));
            this.btnListaAsistenci.Location = new System.Drawing.Point(902, 162);
            this.btnListaAsistenci.Name = "btnListaAsistenci";
            this.btnListaAsistenci.Size = new System.Drawing.Size(39, 28);
            this.btnListaAsistenci.TabIndex = 10020;
            this.btnListaAsistenci.UseVisualStyleBackColor = true;
            this.btnListaAsistenci.Click += new System.EventHandler(this.btnListaAsistenci_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 234);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 10019;
            this.label11.Text = "Descripción";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 130);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 10018;
            this.label10.Text = "Sala / Laboratorio";
            // 
            // cboSala
            // 
            this.cboSala.FormattingEnabled = true;
            this.cboSala.Location = new System.Drawing.Point(166, 130);
            this.cboSala.Margin = new System.Windows.Forms.Padding(4);
            this.cboSala.Name = "cboSala";
            this.cboSala.Size = new System.Drawing.Size(775, 24);
            this.cboSala.TabIndex = 10017;
            this.cboSala.SelectedIndexChanged += new System.EventHandler(this.cboSala_SelectedIndexChanged);
            // 
            // dtpicker2
            // 
            this.dtpicker2.Location = new System.Drawing.Point(612, 96);
            this.dtpicker2.Name = "dtpicker2";
            this.dtpicker2.Size = new System.Drawing.Size(329, 22);
            this.dtpicker2.TabIndex = 10016;
            this.dtpicker2.Value = new System.DateTime(2021, 8, 22, 2, 40, 36, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(535, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 10015;
            this.label9.Text = "Fecha Fin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 10014;
            this.label8.Text = "Fecha Inicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 10013;
            this.label7.Text = "Lista Equipos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 10012;
            this.label3.Text = "Lista de asistentes";
            // 
            // dtpicker1
            // 
            this.dtpicker1.Location = new System.Drawing.Point(166, 96);
            this.dtpicker1.Name = "dtpicker1";
            this.dtpicker1.Size = new System.Drawing.Size(353, 22);
            this.dtpicker1.TabIndex = 10011;
            this.dtpicker1.Value = new System.DateTime(2021, 8, 22, 2, 40, 36, 0);
            // 
            // btnListaEquipos
            // 
            this.btnListaEquipos.Image = ((System.Drawing.Image)(resources.GetObject("btnListaEquipos.Image")));
            this.btnListaEquipos.Location = new System.Drawing.Point(902, 197);
            this.btnListaEquipos.Name = "btnListaEquipos";
            this.btnListaEquipos.Size = new System.Drawing.Size(39, 27);
            this.btnListaEquipos.TabIndex = 10008;
            this.btnListaEquipos.UseVisualStyleBackColor = true;
            this.btnListaEquipos.Click += new System.EventHandler(this.btnListaEquipos_Click);
            // 
            // txtrolresponsable
            // 
            this.txtrolresponsable.Location = new System.Drawing.Point(166, 65);
            this.txtrolresponsable.Margin = new System.Windows.Forms.Padding(4);
            this.txtrolresponsable.Name = "txtrolresponsable";
            this.txtrolresponsable.Size = new System.Drawing.Size(775, 22);
            this.txtrolresponsable.TabIndex = 10007;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 10006;
            this.label1.Text = "Responsable";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-89, -14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 10003;
            this.label5.Text = "Start:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-89, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 10004;
            this.label4.Text = "End:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AcceptsReturn = true;
            this.txtDescripcion.Location = new System.Drawing.Point(166, 231);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(775, 147);
            this.txtDescripcion.TabIndex = 10002;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-85, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 10005;
            this.label6.Text = "Description";
            // 
            // txtnombreactividad
            // 
            this.txtnombreactividad.Location = new System.Drawing.Point(166, 35);
            this.txtnombreactividad.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombreactividad.Name = "txtnombreactividad";
            this.txtnombreactividad.Size = new System.Drawing.Size(775, 22);
            this.txtnombreactividad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(115, 23);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(189, 22);
            this.txtcodigo.TabIndex = 1;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnActualizar.Location = new System.Drawing.Point(1101, 69);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 47);
            this.btnActualizar.TabIndex = 57;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::CapaPresentacion.Properties.Resources.Save_as;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGrabar.Location = new System.Drawing.Point(1101, 21);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(104, 41);
            this.btnGrabar.TabIndex = 55;
            this.btnGrabar.Text = "Grabar ";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(1101, 169);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(104, 82);
            this.btnImprimir.TabIndex = 54;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click_1);
            // 
            // btnAnular
            // 
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(1101, 123);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(104, 39);
            this.btnAnular.TabIndex = 58;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // txtidActividades
            // 
            this.txtidActividades.Location = new System.Drawing.Point(832, 23);
            this.txtidActividades.Margin = new System.Windows.Forms.Padding(4);
            this.txtidActividades.Name = "txtidActividades";
            this.txtidActividades.Size = new System.Drawing.Size(189, 22);
            this.txtidActividades.TabIndex = 37;
            this.txtidActividades.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "Código";
            // 
            // FrmActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1257, 555);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmActividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: MANTENEDOR DE ACTIVIDADES ::";
            this.Load += new System.EventHandler(this.FrmActividades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LblLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblBuscar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtnombreactividad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtrolresponsable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboSala;
        private System.Windows.Forms.DateTimePicker dtpicker2;
        private System.Windows.Forms.Button btnListaEquipos;
        private System.Windows.Forms.PictureBox LblBuscar;
        private System.Windows.Forms.PictureBox LblLimpiar;
        private System.Windows.Forms.Button btnListaAsistenci;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cboListaEquipos;
        private System.Windows.Forms.ComboBox cboAsistencias;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.TextBox txtidActividades;
        private System.Windows.Forms.Label label12;
    }
}