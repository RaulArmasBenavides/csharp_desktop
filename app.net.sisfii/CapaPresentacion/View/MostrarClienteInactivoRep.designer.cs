namespace Casting.Reportes
{
    partial class MostrarClienteInactivoRep
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReporteClienteInactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCasting = new Casting.Reportes.dbCasting();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteClienteInactTableAdapter = new Casting.Reportes.dbCastingTableAdapters.ReporteClienteInactTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteClienteInactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCasting)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteClienteInactBindingSource
            // 
            this.ReporteClienteInactBindingSource.DataMember = "ReporteClienteInact";
            this.ReporteClienteInactBindingSource.DataSource = this.dbCasting;
            // 
            // dbCasting
            // 
            this.dbCasting.DataSetName = "dbCasting";
            this.dbCasting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteClienteInactBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Casting.Reportes.ClienteInactivo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(852, 408);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteClienteInactTableAdapter
            // 
            this.ReporteClienteInactTableAdapter.ClearBeforeFill = true;
            // 
            // MostrarClienteInactivoRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 408);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MostrarClienteInactivoRep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MostrarClienteInactivoRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteClienteInactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCasting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteClienteInactBindingSource;
        private dbCasting dbCasting;
        private dbCastingTableAdapters.ReporteClienteInactTableAdapter ReporteClienteInactTableAdapter;
    }
}