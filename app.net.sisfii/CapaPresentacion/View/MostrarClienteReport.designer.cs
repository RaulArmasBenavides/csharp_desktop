namespace Casting.Reportes
{
    partial class MostrarClienteReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteClienteActBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCasting = new Casting.Reportes.dbCasting();
            this.ReporteClienteActTableAdapter = new Casting.Reportes.dbCastingTableAdapters.ReporteClienteActTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteClienteActBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCasting)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteClienteActBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Casting.Reportes.Cliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(842, 446);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteClienteActBindingSource
            // 
            this.ReporteClienteActBindingSource.DataMember = "ReporteClienteAct";
            this.ReporteClienteActBindingSource.DataSource = this.dbCasting;
            // 
            // dbCasting
            // 
            this.dbCasting.DataSetName = "dbCasting";
            this.dbCasting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteClienteActTableAdapter
            // 
            this.ReporteClienteActTableAdapter.ClearBeforeFill = true;
            // 
            // MostrarClienteReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(842, 446);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MostrarClienteReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MostrarClienteReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteClienteActBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCasting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteClienteActBindingSource;
        private dbCasting dbCasting;
        private dbCastingTableAdapters.ReporteClienteActTableAdapter ReporteClienteActTableAdapter;

    }
}