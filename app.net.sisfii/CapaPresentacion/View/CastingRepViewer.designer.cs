namespace Casting.Reportes
{
    partial class CastingRepViewer
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
            this.dbCasting = new Casting.Reportes.dbCasting();
            this.ReporteAgenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteAgenteTableAdapter = new Casting.Reportes.dbCastingTableAdapters.ReporteAgenteTableAdapter();
            this.ReporteCastingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteCastingTableAdapter = new Casting.Reportes.dbCastingTableAdapters.ReporteCastingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbCasting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteAgenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCastingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteCastingBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Casting.Reportes.CastingReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(831, 467);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbCasting
            // 
            this.dbCasting.DataSetName = "dbCasting";
            this.dbCasting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteAgenteBindingSource
            // 
            this.ReporteAgenteBindingSource.DataMember = "ReporteAgente";
            this.ReporteAgenteBindingSource.DataSource = this.dbCasting;
            // 
            // ReporteAgenteTableAdapter
            // 
            this.ReporteAgenteTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCastingBindingSource
            // 
            this.ReporteCastingBindingSource.DataMember = "ReporteCasting";
            this.ReporteCastingBindingSource.DataSource = this.dbCasting;
            // 
            // ReporteCastingTableAdapter
            // 
            this.ReporteCastingTableAdapter.ClearBeforeFill = true;
            // 
            // CastingRepViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 467);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CastingRepViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CastingRepViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbCasting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteAgenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCastingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteAgenteBindingSource;
        private dbCasting dbCasting;
        private dbCastingTableAdapters.ReporteAgenteTableAdapter ReporteAgenteTableAdapter;
        private System.Windows.Forms.BindingSource ReporteCastingBindingSource;
        private dbCastingTableAdapters.ReporteCastingTableAdapter ReporteCastingTableAdapter;
    }
}