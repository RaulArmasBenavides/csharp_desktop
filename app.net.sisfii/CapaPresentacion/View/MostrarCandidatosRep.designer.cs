namespace Casting.Reportes
{
    partial class MostrarCandidatosRep
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.MostrarPerfilesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCasting = new Casting.Reportes.dbCasting();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CandidatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CandidatosTableAdapter = new Casting.Reportes.dbCastingTableAdapters.CandidatosTableAdapter();
            this.MostrarPerfilesReportTableAdapter = new Casting.Reportes.dbCastingTableAdapters.MostrarPerfilesReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarPerfilesReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCasting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MostrarPerfilesReportBindingSource
            // 
            this.MostrarPerfilesReportBindingSource.DataMember = "MostrarPerfilesReport";
            this.MostrarPerfilesReportBindingSource.DataSource = this.dbCasting;
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
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.MostrarPerfilesReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Casting.Reportes.CandidatoPefiles.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(809, 444);
            this.reportViewer1.TabIndex = 0;
            // 
            // CandidatosBindingSource
            // 
            this.CandidatosBindingSource.DataMember = "Candidatos";
            this.CandidatosBindingSource.DataSource = this.dbCasting;
            // 
            // CandidatosTableAdapter
            // 
            this.CandidatosTableAdapter.ClearBeforeFill = true;
            // 
            // MostrarPerfilesReportTableAdapter
            // 
            this.MostrarPerfilesReportTableAdapter.ClearBeforeFill = true;
            // 
            // MostrarCandidatosRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 444);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MostrarCandidatosRep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MostrarCandidatosRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MostrarPerfilesReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCasting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CandidatosBindingSource;
        private dbCasting dbCasting;
        private dbCastingTableAdapters.CandidatosTableAdapter CandidatosTableAdapter;
        private System.Windows.Forms.BindingSource MostrarPerfilesReportBindingSource;
        private dbCastingTableAdapters.MostrarPerfilesReportTableAdapter MostrarPerfilesReportTableAdapter;
    }
}