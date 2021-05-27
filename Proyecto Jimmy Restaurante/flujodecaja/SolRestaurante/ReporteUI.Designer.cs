namespace SolRestaurante
{
    partial class ReporteUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdReservacion = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtgMov = new System.Windows.Forms.DataGridView();
            this.btnReporte = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.documento = new System.Drawing.Printing.PrintDocument();
            this.pdImpresion = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMov)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador";
            // 
            // txtIdReservacion
            // 
            this.txtIdReservacion.Location = new System.Drawing.Point(119, 39);
            this.txtIdReservacion.Name = "txtIdReservacion";
            this.txtIdReservacion.Size = new System.Drawing.Size(100, 20);
            this.txtIdReservacion.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(119, 61);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // dtgMov
            // 
            this.dtgMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMov.Location = new System.Drawing.Point(25, 87);
            this.dtgMov.Name = "dtgMov";
            this.dtgMov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMov.Size = new System.Drawing.Size(429, 173);
            this.dtgMov.TabIndex = 8;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(349, 285);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(105, 23);
            this.btnReporte.TabIndex = 9;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha";
            // 
            // button1
            // 
            this.button1.Image = global::SolRestaurante.Properties.Resources.buscar;
            this.button1.Location = new System.Drawing.Point(379, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // documento
            // 
            this.documento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pdImpresion
            // 
            this.pdImpresion.UseEXDialog = true;
            // 
            // ReporteUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.dtgMov);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdReservacion);
            this.Controls.Add(this.label1);
            this.Name = "ReporteUI";
            this.Text = "Reporte de FLujo de Caja";
            this.Load += new System.EventHandler(this.ReservacionUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdReservacion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dtgMov;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.PrintDialog pdImpresion;
    }
}